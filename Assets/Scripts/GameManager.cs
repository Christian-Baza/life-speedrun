using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float StartTime = 60f;
    public string TimeLeft = "60";
    public TMP_Text TimeLeftText;
    public Image TimeLeftBar;
    float timePassed;
    public GameObject gameOverUI;
    public TMP_Text gameOverText;

    public GameObject[] items;/*
    0: Normal Key
    1: Golden Key
    2: Car Key
    3: Knife
    4: Fork
    5: Candle
    6: Power stones (Jag kallar de Gems i min kod)
    */public int[] itemsAmount;
    public TMP_Text hoverText;
    public GameObject hoverTextObject;
    
    private void Start()
    {
        timePassed = StartTime + Time.time;
    }
    private void Update()
    {
        if (timePassed <= Time.time)
        {
            TimeLeft = "0s";
            EndScene("You didn't make it in time for the leaderboards", 0);
        }
        else
        {
            TimeLeft = (timePassed - Time.time).ToString("F1") + "s";
            
        }
        TimeLeftText.text = TimeLeft;
        TimeLeftBar.fillAmount = (timePassed - Time.time) / StartTime;

        for (int i = 0; i < items.Length; i++)
        {
            if(itemsAmount[i] > 0)
            {
                items[i].SetActive(true);
                items[i].GetComponentInChildren<TMP_Text>().text = itemsAmount[i].ToString();
            }
            else
            {
                items[i].SetActive(false);
            }
        }

        if (hoverText.text != null && hoverText.text != "")
        {
            hoverTextObject.SetActive(true);
        }
        else
        {
            hoverTextObject.SetActive(false);
        }
    }
    public void EndScene(string gameOverTextString, int ending)
    {
        Time.timeScale = 0f;
        gameOverUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;

        gameOverText.text = gameOverTextString;
        PlayerPrefs.SetInt("Ending " + ending, 1);
    }
    public void GainItem(int Item)
    {
        itemsAmount[Item] += 1;
    }
    private void Awake()
    {
        Time.timeScale = 1f;
    }
}
