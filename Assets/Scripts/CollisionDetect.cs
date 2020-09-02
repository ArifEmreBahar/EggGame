using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{

    public bool isJumped;
    public bool isWater;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D colli)
    {
        if (colli.CompareTag("Ground"))
        {
            isJumped = true;
        }
        if (colli.CompareTag("Water"))
        {
            isWater = true;
        }
    }
    private void OnTriggerExit2D(Collider2D colli)
    {
        isJumped = false;
        isWater = false;
    }

}
