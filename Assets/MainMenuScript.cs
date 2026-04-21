using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
   

  public void playgame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void highScore()
    {
        SceneManager.LoadSceneAsync(2);
       
    }
   

    public void Quit()
    {
        Application.Quit();
    }
}
