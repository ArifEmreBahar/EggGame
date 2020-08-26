using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{

    private Transform[] Layers;
    public GameObject Layer;
    private float[] Delays;
    public float backGroundSize;
    public Transform player;

    //float textureUniteSizex;

    void Start()
    {
        Layers = new Transform[transform.childCount];
        Delays = new float[transform.childCount];

        for (int i = 0; i < transform.childCount; i++) {
            Layers[i] = Layer.transform.GetChild(i);
            Delays[i] = (1f / transform.childCount)*i;
        }
        
        //Layer1.transform.position = player.transform.position;
        //PontoOriginal = transform.position.x;
        //Texture2D texture = Layer1.GetComponent<SpriteRenderer>().sprite.texture;
        //textureUniteSizex = texture.width / Layer1.GetComponent<SpriteRenderer>().sprite.pixelsPerUnit;
    }

    void FixedUpdate()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Layers[i].transform.position= new Vector2(player.transform.position.x * Delays[i] , Layers[i].transform.position.y);
            //if(lastPosition.x > Layers[i].transform.position.x)
        }

        /*
        if (lastPosition.x > (startPosition1 + (Layer1.GetComponent<SpriteRenderer>().bounds.size.x)))
        {
            Layer1.transform.Translate(Layer1.GetComponent<SpriteRenderer>().bounds.size.x, 0, 0);
            startPosition1 = lastPosition.x;
        }*/
    }
}
