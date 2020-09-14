using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingRoom : MonoBehaviour
{
    public GameObject isActiveVirtualCam;
    public GameObject Player;
    public float room2StuckTime;
    public GameObject intro;
    private bool done= true;
    private bool done2 = false;
    public float slowDownFactor = 0.05f;
    public float slowMoDelayTime = 10f;
    public GameObject destroyRoom;

 
        //public GameObject mainCamera;

        private void Update()
    {
        if (isActiveVirtualCam.activeSelf && done)
        {
            StartCoroutine(WaitTime(room2StuckTime));
            StartCoroutine(SlowMoTime(slowMoDelayTime));
            done = false; 
        }
        if (done2 == true) {
            Player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -10));
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
            destroyRoom.SetActive(false);
        }
    }

     IEnumerator WaitTime(float time)
     {
       yield return new WaitForSeconds(time);
       Player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -250));
     }

    IEnumerator SlowMoTime(float time)
    {
        yield return new WaitForSeconds(time);
        doSlowMo();
        yield return new WaitForSecondsRealtime(1f);
        intro.SetActive(true);
        yield return new WaitForSecondsRealtime(3f);
        fixSlowMo();
        done2 = true;
    }
    public void doSlowMo()
    {
        Time.timeScale = slowDownFactor;
        //Time.fixedDeltaTime = Time.timeScale * .02f;
        //StartCoroutine(slowMoTime());
    }
    private void fixSlowMo() {
        Time.timeScale = 1f;
    }
}
