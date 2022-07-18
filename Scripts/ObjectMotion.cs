
using UnityEngine;

public class ObjectMotion : MonoBehaviour
{
    public Transform player;
    private float seconds = 1.5f;
    private float timer =0.0f;
    public Vector3 point ;
    private Vector3 Difference;
    private Vector3 start;
    private float percent;
    public float playerPosition;
    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;
        Difference = point - start;
    //     float zPos = transform.position.z - 5.0f;
    //     point = new Vector3(-0.15f, 0, 64);
}

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z - player.position.z <= playerPosition)
        {

            if (timer <= seconds)
            {
                // basic timer
                timer += Time.deltaTime;
                // percent is a 0-1 float showing the percentage of time that has passed on our timer!
                percent = timer / seconds;
                // multiply the percentage to the difference of our two positions
                // and add to the start
                transform.position = start + Difference * percent;
            }
        }

    }
}
