using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveScript : MonoBehaviour
{
    public GameObject[] EndingSquares;

    public TMP_Text endingsCompletedText;
    int endingsCompleted;
    private void Update()
    {
        for (int i = 0; i < EndingSquares.Length; i++)
        {
            if (PlayerPrefs.GetInt("Ending " + (i + 1)) == 1)
            {
                EndingSquares[i].GetComponent<Button>().interactable = true;
                endingsCompleted++;
            }
            else if (PlayerPrefs.GetInt("Ending " + (i + 1)) == 0)
            {
                EndingSquares[i].GetComponent<Button>().interactable = false;
            }
        }
        endingsCompletedText.text = endingsCompleted + " / " + EndingSquares.Length;
        endingsCompleted = 0;
    }

    public void ResetAll()
    {
        PlayerPrefs.DeleteAll();
    }
}
