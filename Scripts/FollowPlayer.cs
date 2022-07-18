using UnityEngine;
using Unity.Collections;

public class FollowPlayer : MonoBehaviour
{
   
    public Transform player;
    private Vector3 offset;
    private Vector3 moveVector;
    private float transition = 0.0f;
    private float animationDuration = 3.0f;
    private Vector3 animationOffset = new Vector3(0, 5, 5);

     void Start()
    {
        offset = transform.position - player.position;
    }
    void Update()
    {
        moveVector = player.position + offset;

        moveVector.x = 0;
        moveVector.y = Mathf.Clamp(moveVector.y, 2, 5);

        if(transition > 1.0f)
        {
            
        transform.position = moveVector;
        }
        else
        {
            // animation
            transform.position = Vector3.Lerp(moveVector + animationOffset, moveVector, transition);
            transition += Time.deltaTime * 1 / animationDuration;
            transform.LookAt(player.position + Vector3.up);
        }

    }
}
