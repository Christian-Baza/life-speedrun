using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(BoxCollider))]
public class targetpickupp : MonoBehaviour
{
    public float health = 100f;

    public int ID = 0;
    public string hoverText;
    public bool isItem = true;
    public Animator animator;
    /* Item IDs
    0: Normal Key
    1: Golden Key
    2: Car Key
    3: Knife
    4: Fork
    5: Candle
    6: Power stones (Jag kallar de Gems i min kod)

    Interactables IDs
    0: Door
    1: Basement door
    2: Car door
    3: Outlet
    4: Ritual
    5: Ritual second stage
    6: Gauntlet
    7: Gauntlet second stage
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