using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject Layer12;
    public GameObject Layer11;
    public GameObject Layer10;
    public GameObject Layer9;
    public GameObject Layer8;
    public GameObject Layer7;
    public GameObject Layer6;
    public GameObject Layer5;
    public GameObject Layer4;
    public GameObject Layer3;
    public GameObject Layer2;
    public GameObject Layer1;

    public Transform player;


    private Vector3 lastPosition;
    float startPosition1;
    float startPosition2;
    float startPosition3;
    float startPosition4;
    float startPosition5;
    float startPosition6;
    float startPosition7;
    float startPosition8;
    float startPosition9;
    float startPosition10;
    float startPosition11;
    float startPosition12;

    float textureUniteSizex;

    // Use this for initialization
    void Start()
    {
        lastPosition = player.transform.position;
        startPosition1 = player.transform.position.x;
        startPosition2 = player.transform.position.x;
        startPosition3 = player.transform.position.x;
        startPosition4 = player.transform.position.x;
        startPosition5 = player.transform.position.x;
        startPosition6 = player.transform.position.x;
        startPosition7 = player.transform.position.x;
        startPosition8 = player.transform.position.x;
        startPosition9 = player.transform.position.x;
        startPosition10 = player.transform.position.x;
        startPosition11 = player.transform.position.x;
        startPosition12 = player.transform.position.x;
        //Layer1.transform.position = player.transform.position;
        //PontoOriginal = transform.position.x;
        Texture2D texture = Layer1.GetComponent<SpriteRenderer>().sprite.texture;
        textureUniteSizex = texture.width / Layer1.GetComponent<SpriteRenderer>().sprite.pixelsPerUnit;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movementSide = player.transform.position - lastPosition;
        lastPosition = player.transform.position;


        Layer12.transform.Translate(movementSide.x * 1f, 0, 0);
        Layer11.transform.Translate(movementSide.x * 0.9f, 0, 0);
        Layer10.transform.Translate(movementSide.x * 0.8f, 0, 0);
        Layer9.transform.Translate(movementSide.x * 0.7f, 0, 0);
        Layer8.transform.Translate(movementSide.x * 0.6f, 0, 0);
        Layer7.transform.Translate(movementSide.x * 0.5f, 0, 0);
        Layer6.transform.Translate(movementSide.x * 0.4f, 0, 0);
        Layer5.transform.Translate(movementSide.x * 0.3f, 0, 0);
        Layer4.transform.Translate(movementSide.x * 0.2f, 0, 0);
        Layer3.transform.Translate(movementSide.x * 0.1f, 0, 0);
        Layer2.transform.Translate(movementSide.x * 0, 0, 0);
        Layer1.transform.Translate(movementSide.x * 0, 0, 0);
        /*
        float temp = (player.transform.position.x * (1 - 0.9f));
        float dist = (player.transform.position.x * 0.9f);

        Layer11.transform.position = new Vector3(startPosition + dist, transform.position.y, transform.position.z);*/

        if (lastPosition.x > (startPosition1 + (Layer1.GetComponent<SpriteRenderer>().bounds.size.x)))
        {
            Layer1.transform.Translate(Layer1.GetComponent<SpriteRenderer>().bounds.size.x, 0, 0);
            startPosition1 = lastPosition.x;
        }
        if (lastPosition.x > (startPosition2 + (Layer2.GetComponent<SpriteRenderer>().bounds.size.x)))
        {
            Layer2.transform.Translate(Layer2.GetComponent<SpriteRenderer>().bounds.size.x , 0, 0);
            startPosition2 = lastPosition.x;
        }
        if (lastPosition.x*0.9f > (startPosition3 + (Layer3.GetComponent<SpriteRenderer>().bounds.size.x )))
        {
            Layer3.transform.Translate(Layer3.GetComponent<SpriteRenderer>().bounds.size.x , 0, 0);
            startPosition3 = lastPosition.x;
        }
        if (lastPosition.x*0.8f > (startPosition4 + (Layer4.GetComponent<SpriteRenderer>().bounds.size.x)))
        {
            Layer4.transform.Translate(Layer4.GetComponent<SpriteRenderer>().bounds.size.x, 0, 0);
            startPosition4 = lastPosition.x;
        }
        if (lastPosition.x*0.7f > (startPosition5 + (Layer5.GetComponent<SpriteRenderer>().bounds.size.x)))
        {
            Layer5.transform.Translate(Layer5.GetComponent<SpriteRenderer>().bounds.size.x, 0, 0);
            startPosition5 = lastPosition.x;
        }
        if (lastPosition.x*0.6f > (startPosition6 + (Layer6.GetComponent<SpriteRenderer>().bounds.size.x)))
        {
            Layer6.transform.Translate(Layer6.GetComponent<SpriteRenderer>().bounds.size.x, 0, 0);
            startPosition6 = lastPosition.x;
        }
        if (lastPosition.x*0.5f > (startPosition7 + (Layer7.GetComponent<SpriteRenderer>().bounds.size.x)))
        {
            Layer7.transform.Translate(Layer7.GetComponent<SpriteRenderer>().bounds.size.x, 0, 0);
            startPosition7 = lastPosition.x;
        }
        if (lastPosition.x*0.4f > (startPosition8 + (Layer8.GetComponent<SpriteRenderer>().bounds.size.x)))
        {
            Layer8.transform.Translate(Layer8.GetComponent<SpriteRenderer>().bounds.size.x , 0, 0);
            startPosition8 = lastPosition.x;
        }
        if (lastPosition.x*0.3f > (startPosition9 + (Layer9.GetComponent<SpriteRenderer>().bounds.size.x)))
        {
            Layer9.transform.Translate(Layer9.GetComponent<SpriteRenderer>().bounds.size.x, 0, 0);
            startPosition9 = lastPosition.x;
        }
        if (lastPosition.x*0.2f > (startPosition10 + (Layer10.GetComponent<SpriteRenderer>().bounds.size.x * 0.9f)))
        {
            Layer10.transform.Translate(Layer10.GetComponent<SpriteRenderer>().bounds.size.x * 0.9f, 0, 0);
            startPosition10 = lastPosition.x;
        }
        if (lastPosition.x*0.1f > (startPosition11 + (Layer11.GetComponent<SpriteRenderer>().bounds.size.x)))
        {
            Layer11.transform.Translate(Layer11.GetComponent<SpriteRenderer>().bounds.size.x, 0, 0);
            startPosition11 = lastPosition.x;
        }
        if (lastPosition.x > (startPosition12 + (Layer12.GetComponent<SpriteRenderer>().bounds.size.x)))
        {
            Layer12.transform.Translate(Layer12.GetComponent<SpriteRenderer>().bounds.size.x, 0, 0);
            startPosition12 = lastPosition.x;
        }




        /*else if(lastPosition.x - startPosition <= Layer1.GetComponent<SpriteRenderer>().bounds.size.x / 2f)
        {
            Layer1.transform.Translate(-Layer1.GetComponent<SpriteRenderer>().bounds.size.x, 0, 0);
            startPosition = lastPosition.x;
        }
        
            Layer12.transform.Translate(Layer12.GetComponent<SpriteRenderer>().bounds.size.x, 0, 0);
            Layer11.transform.Translate(Layer12.GetComponent<SpriteRenderer>().bounds.size.x, 0, 0);
            Layer10.transform.Translate(Layer12.GetComponent<SpriteRenderer>().bounds.size.x, 0, 0);
            Layer9.transform.Translate(Layer12.GetComponent<SpriteRenderer>().bounds.size.x, 0, 0);
            Layer8.transform.Translate(Layer12.GetComponent<SpriteRenderer>().bounds.size.x, 0, 0);
            Layer7.transform.Translate(Layer12.GetComponent<SpriteRenderer>().bounds.size.x, 0, 0);
            Layer6.transform.Translate(Layer12.GetComponent<SpriteRenderer>().bounds.size.x, 0, 0);
            Layer5.transform.Translate(Layer12.GetComponent<SpriteRenderer>().bounds.size.x, 0, 0);
            Layer4.transform.Translate(Layer12.GetComponent<SpriteRenderer>().bounds.size.x, 0, 0);
            Layer3.transform.Translate(Layer12.GetComponent<SpriteRenderer>().bounds.size.x, 0, 0);
            Layer2.transform.Translate(Layer12.GetComponent<SpriteRenderer>().bounds.size.x, 0, 0);*/





        /*
        x = transform.position.x;
        x += speed * Time.deltaTime;
        transform.position = new Vector3(x, transform.position.y, transform.position.z);

        if (x <= PontoDeDestino)
        {
            Debug.Log("hhhh");
            x = PontoOriginal;
            transform.position = new Vector3(x, transform.position.y, transform.position.z);
        }*/
    }
}
