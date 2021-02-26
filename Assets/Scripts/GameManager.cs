using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float StartTime = 60f;
    public string TimeLeft = "60";
    public TMP_Text TimeLeftUI;
    float timePassed;
    public GameObject gameOverUI;
    public TMP_Text gameOverText;

    private void Start()
    {
        timePassed = StartTime + Time.time;
    }
    private void Update()
    {
        if (timePassed <= Time.time)
        {
            TimeLeft = "0s";
            EndScene(false);
        }
        else
        {
            TimeLeft = (timePassed - Time.time).ToString("F1") + "s";
            
        }
        TimeLeftUI.text = TimeLeft;
    }
    private void EndScene(bool wonGame)
    {
        Time.timeScale = 0f;
        gameOverUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;

        gameOverText.text = "You didn't make it in time for the leaderboards";
    }
    private void Awake()
    {
        Time.timeScale = 1f;
    }
}
