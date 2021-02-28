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
        for (int i = 0; i < EndingSquares.Length; ++i)
        {
            if (PlayerPrefs.GetInt("Ending " + i) == 1)
            {
                print(i);
                EndingSquares[i - 1].GetComponent<Button>().interactable = true;
                endingsCompleted += 1;
            }
        }
        endingsCompletedText.text = endingsCompleted + " / " + EndingSquares.Length;
        endingsCompleted = 0;
    }
}
