
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip hitSound, deathSound, victorySound, jumpSound;
    public static AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        hitSound = Resources.Load<AudioClip>("Hit");
        deathSound = Resources.Load<AudioClip>("Death");
        victorySound = Resources.Load<AudioClip>("Victory");
        jumpSound = Resources.Load<AudioClip>("Jump");

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch(clip)
        {
            case "hit":
                audioSource.PlayOneShot(hitSound);
                break;
            case "death":
                audioSource.PlayOneShot(deathSound);
                break;
            case "victory":
                audioSource.PlayOneShot(victorySound);
                break;
            case "jump":
                audioSource.PlayOneShot(jumpSound);
                break;
        }
    }
}
