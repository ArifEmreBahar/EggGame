using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other != null && other.tag != null)
        {
            if (other.CompareTag("Player"))
            {
                GameObject.Find("White").GetComponent<SpawnPlayer>().lastPosition = transform.position;
                Destroy(gameObject);
            }
        }
    }
}
