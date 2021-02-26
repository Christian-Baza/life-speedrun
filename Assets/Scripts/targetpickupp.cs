using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetpickupp : MonoBehaviour
{
    public float health = 100f;

    public GameObject cam;


    public void Start()
    {

    }


    public void takedamage(float amount)
    {// det hela skripetet gör är holler hp på objektet den siter på och sedan ifall det är mindte en 0 eller är så destoryar jag det
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {// tar bort objetet
        Destroy(gameObject);
    }

}