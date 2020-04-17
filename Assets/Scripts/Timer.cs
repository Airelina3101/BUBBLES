using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text _text;
    public int timeLeft;
    private float gameTime;
    public GameObject EndGame;
    public GameObject ScorePanel;
    void Start()
    {
        timeLeft = 60;
        Time.timeScale = 1;
    }
    void Update()
    {
        _text.text = "Осталось " + timeLeft;
        gameTime += 1 * Time.deltaTime;
        if (gameTime >= 1) {
            timeLeft -= 1;
            gameTime = 0;
        }
        if (timeLeft < 20)
        {
            _text.color = Color.red;
        }
        if (timeLeft == 0)
        {
            timeLeft = -1;
            Kill();

        }
    }
    void Kill()
    {
        Time.timeScale = 0;
        EndGame.SetActive(!EndGame.activeSelf);
        ScorePanel.SetActive(!ScorePanel.activeSelf);
    }
}
