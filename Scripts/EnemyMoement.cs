
using UnityEngine;

public class EnemyMoement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private bool isKilling = false;

   // public CharacterAnimation animation;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            if (player.transform.position.z - transform.position.z <= 0.5 && transform.position.x - player.transform.position.x <= 0.5)
            {
            if (!isKilling)
            {
                FindObjectOfType<GameManager>().Death();
                isKilling = true;
            }
            }
            else if (player.transform.position.z <= 474)
            {
                transform.LookAt(player.transform);
                transform.position += transform.forward * 6.0f * Time.deltaTime;
            }
        

    }
}
