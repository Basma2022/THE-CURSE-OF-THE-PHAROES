using UnityEngine;

public class Appearance : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public float delta;
    public bool appearance;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z - player.position.z <= delta)
        {
            if(appearance)
            GetComponent<Renderer>().enabled = true;
            else
            GetComponent<Renderer>().enabled = false;
        }
    }
}
