using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VirtualCam : MonoBehaviour
{
    public GameObject virtualCam;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            virtualCam.SetActive(true);
            //StartCoroutine(WaitTime(waitTime));
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            virtualCam.SetActive(false);
        }
    }
   /* IEnumerator WaitTime(float time)
    {
        yield return new WaitForSeconds(time);
        virtualCam.SetActive(true);
    }*/
}
