using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{

    public bool isGruond;
    public bool isWater;
    // Start is called before the first frame update
 



    private void OnTriggerStay2D(Collider2D colli)
    {
        if (colli.CompareTag("Ground"))
        {

            isGruond = true;
        }
        if (colli.CompareTag("Water"))
        {
            isWater = true;
        }
    }
    private void OnTriggerExit2D(Collider2D colli)
    {
        isGruond = false;
        isWater = false;
    }

}
