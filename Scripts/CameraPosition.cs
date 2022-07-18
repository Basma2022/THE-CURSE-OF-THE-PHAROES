
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform player;
    private Vector3 offset;
    private Vector3 moveVector;
    void Start()
    {
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        moveVector = player.position + offset;
        moveVector.x = player.position.x;

        if (moveVector.x > 1.0f)
            moveVector.x = 1;
        else if (moveVector.x < -1.0f)
            moveVector.x = -1;

        //    moveVector.y = Mathf.Clamp(moveVector.y, 2, 5);
        moveVector.y = player.position.y +3.1f;
        transform.position = moveVector;

    }
}
