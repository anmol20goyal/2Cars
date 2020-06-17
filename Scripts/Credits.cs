using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void playAgnBtn()
	{
		// Score.score = 0;
		CarCollision.GameHasEnded = false;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}

	public void menuBtn()
	{
		SceneManager.LoadScene(0);
	}

	public void OnApplicationQuit()
	{
		Application.Quit();
	}
}
