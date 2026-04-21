using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

public class LogicManagerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int playerscore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject gamePauseScreen;
    public GameObject pause;
    //public GameObject play;
    public GameObject ResumeButton;
    public int high;
    public AudioSource Gameoversound;


    public bool ispause = false;

    void Start()
    {
        Time.timeScale = 1;

        int highscore = PlayerPrefs.GetInt("high", 0);
        //Debug.Log("High Score: " +highscore);
    }



    [ContextMenu("Increases Score")]
    public void score(int x)
    {

        playerscore += x;
        scoreText.text = playerscore.ToString();


        high = PlayerPrefs.GetInt("high", 0);
        if (playerscore > high)
        {

            PlayerPrefs.SetInt("high", playerscore);
            PlayerPrefs.Save();

        }
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;

        int highscore = PlayerPrefs.GetInt("high", 0); 
        Debug.Log("High Score (still preserved): "  +highscore);
    }

    public void gameover()
    {

        Gameoversound.Play();
        pause.SetActive(false);
        gameOverScreen.SetActive(true);
        gamePauseScreen.SetActive(true);
        ResumeButton.SetActive(false);
        Time.timeScale = 0;

        

    }
    public void pausegame()
    {
        gamePauseScreen.SetActive(true);
        
        Time.timeScale = 0;
        //play.SetActive(false);
        pause.SetActive(false);
    }
    public void resumegame()
    {
        gamePauseScreen.SetActive(false);
        //play.SetActive(true);
        Time.timeScale = 1;
        pause.SetActive(true);
    }

    public void menu()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void highscore()
    {
        SceneManager.LoadSceneAsync(2);
    }


}
