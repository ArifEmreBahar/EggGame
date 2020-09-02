using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{

    private Transform[] Layers;
    private float[] Delays;
    public Transform player;
    private float[] startPos;

    void Start()
    {
        Layers = new Transform[transform.childCount];
        Delays = new float[transform.childCount];
        startPos = new float[transform.childCount];

        for (int i = 0; i < transform.childCount; i++) {
            Layers[i] = transform.GetChild(i);
            Delays[i] = (1f / transform.childCount)*i;
            startPos[i]= transform.position.x;
        }
    }

    void FixedUpdate()
    {
            for (int i = 0; i < transform.childCount; i++)
            {
                Layers[i].transform.position = new Vector2(startPos[i] + player.transform.position.x * Delays[i], Layers[i].transform.position.y);
                if (player.transform.position.x > Layers[i].transform.position.x + Layers[i].GetComponent<SpriteRenderer>().bounds.size.x)
                { startPos[i] += Layers[i].GetComponent<SpriteRenderer>().bounds.size.x;
                } else if (player.transform.position.x < Layers[i].transform.position.x - Layers[i].GetComponent<SpriteRenderer>().bounds.size.x)
                { startPos[i] -= Layers[i].GetComponent<SpriteRenderer>().bounds.size.x; }
            }
    }
}
