using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>() != null)
        {
            gameManager.EndScene("You somehow fell out of the world", 2);
        }
    }
}
