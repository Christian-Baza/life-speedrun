using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup : MonoBehaviour
{
    public float damagee = 100F;
    public Camera fpscam;
    public float range = 6f;
    //mask och hur mycket damagee och range och vart den skutes ifårn
    [SerializeField]
    LayerMask mask;

    [SerializeField]
    GameObject key;


    public GameObject pickupefect;


    public Text keystext;
    public int keyamont;

    public Text candelstext;
    public int candelamont;

    public Text knifestext;
    public int knifeamont;

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
                if (hit.transform.name == "key")
                {
                    
                    
                    keyamont += 1;
                    keystext.text = keyamont.ToString();
                  
                    GameObject impactgo = Instantiate(pickupefect , hit.point, Quaternion.LookRotation(hit.normal));
                    Destroy(impactgo, 2f);

                }

                if (hit.transform.name == "candel")
                {
                    print("please");

                    candelamont += 1;
                    candelstext.text = candelamont.ToString();

                }
                
                if (hit.transform.name == "knife")
                {
                    knifeamont += 1;
                    knifestext.text = knifeamont.ToString();
                }
               
                if(hit.transform.name == "autlet"&& knifeamont == 1 )
                {
                    print("die");
                }
                  
                    
                    target.takedamage(damagee);

               
            }
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
}
