
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    // Start is called before the first frame update

    static private Animator playerAnim;
    public Transform player;
    
    void Start()
    {
        playerAnim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public static void VictoryAnimation()
    {
        playerAnim.SetTrigger("Victory");
        SoundManager.PlaySound("victory");
        
    }
    public static void JumpAnimation()
    {
        playerAnim.SetTrigger("jump");
    }
    static public void deathAnimation()
    {
        playerAnim.SetTrigger("Dead");
    }
}
