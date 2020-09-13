using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingRoom : MonoBehaviour
{
    public GameObject isActiveVirtualCam;
    public GameObject Player;
    public float waitTime;
    public float slowMoTime;
    public TimeManager timeManager;
    private bool done= true;
    //public GameObject mainCamera;

    private void Update()
    {
        if (isActiveVirtualCam.activeSelf && Player.GetComponent<Rigidbody2D>().velocity.magnitude < 3f)
        {
            StartCoroutine(WaitTime(waitTime));
            //StartCoroutine(SlowMoTime(slowMoTime));
            //Player.GetComponent<Rigidbody2D>().gravityScale = 0.2f; 
        }
        if (isActiveVirtualCam.activeSelf && done)
        {
            //StartCoroutine(WaitTime(waitTime));
            StartCoroutine(SlowMoTime(slowMoTime));
            done = false;
            //Player.GetComponent<Rigidbody2D>().gravityScale = 0.2f; 
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            Player.GetComponent<Rigidbody2D>().gravityScale = 0f;
            Player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            Player.GetComponent<Rigidbody2D>().angularVelocity = 0f;
            Player.transform.position = new Vector2(0, Player.transform.position.y-1f);
            Player.transform.rotation = Quaternion.identity;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Player.GetComponent<Rigidbody2D>().gravityScale = 2f;
        }
    }

     IEnumerator WaitTime(float time)
     {
       yield return new WaitForSeconds(time);
       Player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -3));
     }

    IEnumerator SlowMoTime(float time)
    {
        yield return new WaitForSeconds(time);
        timeManager.doSlowMo();
    }
}
