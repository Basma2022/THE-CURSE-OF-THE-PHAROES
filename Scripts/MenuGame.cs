
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGame : MonoBehaviour
{
    // Start is called before the first frame update

    public void StartGame()
    {
        SceneManager.LoadScene("StorryScreen1");
    }
  
}
