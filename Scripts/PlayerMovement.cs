
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    
    private CharacterController controller;
    private float currentSpeed = 6.0f;
    private Vector3 moveVector;
    private float verticalVelocity = 0.0f;
    private float graviity = 12.0f;
    private float jumpForce = 5.0f;
    static public bool isMoving = true;
    private bool inVictory = false;
    private float nextSoundTime ;
    private bool jumper = false;


    void Start()
    {
        controller = GetComponent<CharacterController>();
        isMoving = true;
        nextSoundTime = 0;
    }

    // Update is called once per frame
    void Update()
    {

        moveVector = Vector3.zero;

        if(!inVictory)
        {
        if (transform.position.z >= 485.0f)
        {
            CharacterAnimation.VictoryAnimation();
            inVictory = true;
        }
        }

            if (isMoving)
            {

           

            if (controller.isGrounded)
            {
                verticalVelocity = -0.5f;

                if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
                {
                    CharacterAnimation.JumpAnimation();
                    verticalVelocity = jumpForce;
                    SoundManager.PlaySound("jump");
                }
                if (jumper)
                {
                   verticalVelocity = 10.0f;
                   jumper = false;
                }

            }
            else
            {
                verticalVelocity -= graviity * Time.deltaTime;
            }


            // X left and Right 
            moveVector.x = Input.GetAxisRaw("Horizontal") * currentSpeed;
            //Y up and down
            moveVector.y = verticalVelocity;
            // Z forward and backward
            moveVector.z = currentSpeed;
            controller.Move(moveVector * Time.deltaTime);

            if (transform.position.z >= 477.0f && transform.position.z < 496.0f)
                GetComponent<Rotaion>().enabled = true ;
            else
                GetComponent<Rotaion>().enabled = false;

        }
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.point.z > transform.position.z + controller.radius)
        {
            if (Time.time >= nextSoundTime)
            {
                SoundManager.PlaySound("hit");
                nextSoundTime = Time.time + 1.0f;
            }
        }

        if(hit.collider.tag == "Lava" )
        {
            FindObjectOfType<GameManager>().Death();
        }

        if (hit.collider.tag == "Jumper")
        {
            jumper = true;
        }
    }

}
