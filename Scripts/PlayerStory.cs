using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStory : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        Invoke("PlayWalk", 36.0f);
    }

    void Update()
    {
      
    }

    public void PlayWalk()
    {
        anim.SetInteger("Walk", 1);
        Invoke("EnableMovement", 3.5f);
    }

    public void EnableMovement()
    {
        GetComponent<ObjectMotion>().enabled = true;
        Invoke("EnableTouch", 0.7f);
    }

    public void EnableTouch()
    {
        anim.SetTrigger("Touch");
        Invoke("Earhquake", 4f);
    }
    public void Earhquake()
    {
        EarthquakeScript.start = true;
        // 14 sec to end
        Invoke("ToLevel1", 15f);
    }
    public void ToLevel1()
    {
        SceneManager.LoadScene("ControlScreen");

    }
}
