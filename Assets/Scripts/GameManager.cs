using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float TimeLeft;
    public float StartTime = 60f;
    private void Update()
    {
        if (TimeLeft < 0)
        {
            TimeLeft = 0f;
        }
        else
        {
            TimeLeft = StartTime - Time.time;
        }
    }
}
