using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetpickupp : MonoBehaviour
{
    public float health = 100f;

    public int itemID = 0;
    public string hoverText;
    public bool isItem = true;
    /*
    0: Normal Key
    1: Golden Key
    2: Car Key
    3: Knife
    4: Fork
    5: Candle
    6: Power stones (Jag kallar de Gems i min kod)
    */
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