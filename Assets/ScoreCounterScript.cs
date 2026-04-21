using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

public class ScoreCounterScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int playerscore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject gamePauseScreen;
    public GameObject pause;
    public bool ispause = false;



    private void Start()
    {

    }

    private void Update()
    {

    }


    [ContextMenu("Increases Score")]
    public void score(int x)
    {

        playerscore += x;
        scoreText.text = playerscore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void gameover()
    {
        pause.SetActive(false);
        gameOverScreen.SetActive(true);        
        Time.timeScale = 0;
    }
    public void pausegame()
    {
        gamePauseScreen.SetActive(true);
        Time.timeScale = 0;
        pause.SetActive(false);
    }
    public void resumegame()
    {
        gamePauseScreen.SetActive(false);
        Time.timeScale = 1;
         pause.SetActive(true);
    }


}
