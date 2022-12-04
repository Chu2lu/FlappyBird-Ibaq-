using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public int Bscore;
    public Text ScoreText;
    public Text ScorePText;
    public Text ScoreBText;
    public AudioSource puan;
    public GameObject PauseScreen;
    public GameObject StartScreen;
        public void UpdateScore()
    {
        puan.Play();
        score++;
        ScoreText.text = score.ToString();
        ScorePText.text = score.ToString();
    }
    public void StartGame()
    { 
        StartScreen.SetActive(false);
        Time.timeScale= 1;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0); 
    }
    public void ResumeGame()
    { 
      Time.timeScale = 1;
      PauseScreen.SetActive(false);
    }

    public void Sound(bool muted)
    {
        if (muted)
        {
            AudioListener.volume = 0;
        }
        else
        {
            AudioListener.volume = 1;
        }
    }
}
