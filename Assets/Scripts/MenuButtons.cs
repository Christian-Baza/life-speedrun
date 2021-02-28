using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public GameObject[] OpenMenuItems;
    public GameObject[] CloseMenuItems;
    public void RetryLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void StartLevel()
    {
        SceneManager.LoadScene("Level House");
    }
    public void QuitGame()
    {
        PlayerPrefs.Save();
        Application.Quit();
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void OpenMenu()
    {
        foreach (GameObject item in OpenMenuItems)
        {
            item.SetActive(true);
        }
        foreach (GameObject item in CloseMenuItems)
        {
            item.SetActive(false);
        }
    }
}
