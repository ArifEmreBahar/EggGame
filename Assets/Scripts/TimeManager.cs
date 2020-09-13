using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float slowDownFactor=0.05f;
    public float slowDownLength=2f;
    public float time;

 

    public void doSlowMo() {
        Time.timeScale = slowDownFactor;
        Time.fixedDeltaTime = Time.timeScale * .02f;
        StartCoroutine(slowMoTime());
        Debug.Log("1");
    }

    IEnumerator slowMoTime()
    {
        yield return new WaitForSeconds(0.15f);
        Debug.Log("2");
        Time.timeScale = 1f;
    }
}
