using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup : MonoBehaviour
{
    public float damage = 100F;
    public Camera fpscam;
    public float range = 6f;
    //mask och hur mycket damagee och range och vart den skutes ifårn

    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit, range))
        {
            targetpickupp target = hit.transform.GetComponent<targetpickupp>();
            if (target != null)
            {
                gameManager.hoverText.text = target.hoverText;

                if (Input.GetKeyDown(KeyCode.E))
                {
                    pickuupp(target);
                }
            }
            else
            {
                gameManager.hoverText.text = null;
            }
        }
        else
        {
            gameManager.hoverText.text = null;
        }
        
    }
    

           
      
    public void pickuupp(targetpickupp target)
    {   if (target.isItem == true)
        {
            gameManager.GainItem(target.ID);
            target.takedamage(damage);
        }
        else if (target.ID == 3 && gameManager.itemsAmount[4] >= 1)
        {
            gameManager.EndScene("You electrocuted yourself", 1);
        }
        else if (target.ID == 0 && gameManager.itemsAmount[0] >= 1)
        {
            target.animator.SetTrigger("Open door");
        }
        else if (target.ID == 1 && gameManager.itemsAmount[1] >= 1)
        {
            target.animator.SetTrigger("Open door");
        }
        else if (target.ID == 5 && gameManager.itemsAmount[5] >= 5)
        {
            target.animator.SetTrigger("Open door");
        }
        // skapar en ray cast och sedan kollar ifall targeten har ett script på sig som då sedan gör så vi kan läga till damage på det objektet som då vi kan ta bort det objektet
        //GameObject impactgo = Instantiate(pickupefect , hit.point, Quaternion.LookRotation(hit.normal));
        //Destroy(impactgo, 2f);

        //  GameObject impactgo = Instantiate(hitefect, hit.point, Quaternion.LookRotation(hit.normal));
        // Destroy(impactgo, 2f);
        //, range, mask


        // så vi kan kålla efter specifica object i scenen när vi tar bort något så kan vi ändra en bool som sägjer att vi har den elle inte



        /*
       if (key.scene.IsValid())
       {
           print("no");
           // go is an instance of an object that's present in the scene
       }
       else
       {
           print("yes");
           // go is an instance of a prefab
       }
       */




    }
}
