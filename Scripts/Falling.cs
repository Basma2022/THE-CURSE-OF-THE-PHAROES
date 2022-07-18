
using UnityEngine;

public class Falling : MonoBehaviour
{

    public Transform player;
    public Rigidbody rb;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z  -  player.transform.position.z <=distance)
        {
            rb.useGravity = true;
        }
       
    }
}
