using System;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Text bestScore;

    public GameObject InstrUI;
    // Start is called before the first frame update
    void Start()
    {
        bestScore.text = "Best : " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void InstrBtn()
    {
        InstrUI.SetActive(true);
    }
    
    public void playBtn()
    {
        CarCollision.GameHasEnded = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
