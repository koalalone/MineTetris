using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    public int score;
    public int highScore;

    // Start is called before the first frame update
    void Start()
    {

        score = 0;
        scoreText.text = "Score: " + score;
        highScore = PlayerPrefs.GetInt("highscore", highScore);
        highScoreText.SetText("High Score: " + highScore);

    }

    public int AddScore()
    {
        score += 100;
        scoreText.text = "Score: " + score;
        return score;
    }

    public int ResetScore()
    {
        score = 0;
        scoreText.text = "Score: " + score;
        return score;
    }

    public void GameOver()
    {
        if (score > highScore)
        {
            highScore = score;
            highScoreText.text = "High Score: " + highScore;
            PlayerPrefs.SetInt("highscore", score);
        }
    }

}
