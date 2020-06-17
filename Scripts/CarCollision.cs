using UnityEngine.UI;
using UnityEngine;

public class CarCollision : MonoBehaviour
{
    public GameObject gameOverUI;
    public Text scoreText , InGameScore;
    public static bool GameHasEnded = false;
    
    // Update is called once per frame
    private void Update()
    {
        if (GameHasEnded == false)
        {
            GameObject goldBall = GameObject.FindWithTag("gold");
            if (goldBall != null && goldBall.transform.position.y + 0.25f < transform.position.y)
            {
            #if UNITY_ANDROID
                Handheld.Vibrate();
            #endif
                gameOverUI.SetActive(true);
                GameHasEnded = true;
                if (PlayerPrefs.GetInt("HighScore" , 0) < Score.score)
                {
                    PlayerPrefs.SetInt("HighScore", Score.score);
                }
                Score.score = 0;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (GameHasEnded == false)
        {
            if (other.gameObject.tag == "gold")
            {
                // score increases and destroy the gold ball
                Destroy(other.gameObject);
                Score.score++;
                scoreText.text = "Score : " + Score.score;
                InGameScore.text = Score.score.ToString();
            }

            if (other.gameObject.tag == "enemy")
            {
                // game over
            #if UNITY_ANDROID
                Handheld.Vibrate();
            #endif
                if (PlayerPrefs.GetInt("HighScore" , 0) < Score.score)
                {
                    PlayerPrefs.SetInt("HighScore", Score.score);
                }
                GameHasEnded = true;
                Score.score = 0;
                gameOverUI.SetActive(true);
            }
        }
    }
}
