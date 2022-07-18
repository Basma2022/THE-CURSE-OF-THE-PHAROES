
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("StartGame" , 3f);
    }

    void StartGame()
    {
        SceneManager.LoadScene("Level 01");
    }
}
