using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        if(SceneManager.GetActiveScene().name == "Level 05")
            SceneManager.LoadScene("ToBeContScreen");
        else
        gameManager.ShowVictoryMenu();
    }
}
