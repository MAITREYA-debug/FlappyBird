using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HSMainCameraScript : MonoBehaviour
{

    public Text Htext;
    public int highs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
         highs = PlayerPrefs.GetInt("high", 0);
        Htext.text = highs.ToString();

    }

    // Update is called once per frame
    void Update()
    {
       
    }



    public void menu()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void delete()
    {
        PlayerPrefs.DeleteAll();
        Start();
    }


}