using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickupp : MonoBehaviour
{
    public float damagee = 100F;
    public Camera fpscam;
    public float range = 60f;

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
    {// shot funktioen det jag börjar med är att använda mig av reycast och av miten av min skärm på objektet som jag kollar på och sedan kollar jag igall den har damagete gerjern som jag har på ett anat skritpt som då aktiveras och då gör den 25 skada och raconsen har 50 hp så då tar det två skot för att det ska kuna bli 0 eller mindre och då använder jag skripet som inan jag beskrev att den destoryar och sedna spawnaner en ny när den är borta och jag spawnar också en efekt när jag träfar något med min raycas som då jag använder local rotation som betyder att den efekten kommer bli ritkade bordened på objektets rotation och inte någns anans och sitd tar jag bort den efter 2 sek.
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
        }



    }
}
