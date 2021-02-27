using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup : MonoBehaviour
{
    public float damagee = 100F;
    public Camera fpscam;
    public float range = 60f;
    //mask och hur mycket damagee och range och vart den skutes ifårn
    [SerializeField]
    LayerMask mask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

            
            pickuupp();
        }
    }
    

           
      
    public void pickuupp()
    {// skapar en ray cast och sedan kollar ifall targeten har ett script på sig som då sedan gör så vi kan läga till damage på det objektet som då vi kan ta bort det objektet
        RaycastHit hit;
        if (Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit,range)){
            Debug.Log(hit.transform.name);
            targetpickupp target = hit.transform.GetComponent<targetpickupp>();
            if (target != null)
            {
                target.takedamage(damagee);
            }
            //  GameObject impactgo = Instantiate(hitefect, hit.point, Quaternion.LookRotation(hit.normal));
            // Destroy(impactgo, 2f);
            //, range, mask


         // så vi kan kålla efter specifica object i scenen när vi tar bort något så kan vi ändra en bool som sägjer att vi har den elle inte
           /*
            if (GameObject.Find("WhateverItsCalled") = !null)
             {
                //det existerar ej
            }
            */
        }



    }
}
