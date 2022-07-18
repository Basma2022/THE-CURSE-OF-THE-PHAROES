using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    public float delay = 2f;
    public DeathMenu deathMenu;
    // public bool gameHasEnded = false;
    public VictoryMenu victoryMenu;
    
    public void EndGame()
    {
        Invoke("ShowDeathMenu", delay);
    }
    public void ShowDeathMenu()
    {
        deathMenu.OpenDeathMenu();
    }
    public void Restart()
    {
      
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ToMenuGame()
    {
        SceneManager.LoadScene("MenuGameScene");
    }

    public void ShowVictoryMenu()
    {
        victoryMenu.OpenVictoryMenu();
    }
    public void Death()
    {
        PlayerMovement.isMoving = false;
        EnemyAnimation.KillAnimation();
        CharacterAnimation.deathAnimation();
        SoundManager.PlaySound("death");
        FindObjectOfType<GameManager>().EndGame();
      
        
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayLevel1()
    {
        SceneManager.LoadScene("Level 01");
    }
    public void PlayLevel2()
    {
        SceneManager.LoadScene("Level 02");
    }
    public void PlayLevel3()
    {
        SceneManager.LoadScene("Level 03");
    }
    public void PlayLevel4()
    {
        SceneManager.LoadScene("Level 04");
    }
    public void PlayLevel5()
    {
        SceneManager.LoadScene("Level 05");
    }

    public void GoToMap()
    {
        SceneManager.LoadScene("LevelScreen");
    }

   public void Exit()
    {
        Application.Quit();
    }
}
