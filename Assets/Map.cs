using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public Transform Layer12;
    public Transform Layer11;
    public Transform Layer10;
    public Transform Layer9;
    public Transform Layer8;
    public Transform Layer7;
    public Transform Layer6;
    public Transform Layer5;
    public Transform Layer4;
    public Transform Layer3;
    public Transform Layer2;
    public Transform Layer1;

    public Transform player;
    float delay = 1f;

    private Vector3 lastPosition;
    

    // Use this for initialization
    void Start()
    {
        lastPosition=player.transform.position;
        //Layer1.transform.position = player.transform.position;
        //PontoOriginal = transform.position.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movementSide = player.transform.position - lastPosition;
        lastPosition = player.transform.position;

       
        Layer12.transform.Translate(0, 0, 0);
        Layer11.transform.Translate(0, 0, 0);
        Layer10.transform.Translate(movementSide.x *0.1f, 0, 0);
        Layer9.transform.Translate(movementSide.x * 0.2f, 0, 0);
        Layer8.transform.Translate(movementSide.x * 0.3f, 0, 0);
        Layer7.transform.Translate(movementSide.x * 0.4f, 0, 0);
        Layer6.transform.Translate(movementSide.x * 0.5f, 0, 0);
        Layer5.transform.Translate(movementSide.x * 0.6f, 0, 0);
        Layer4.transform.Translate(movementSide.x * 0.7f, 0, 0);
        Layer3.transform.Translate(movementSide.x * 0.8f, 0, 0);
        Layer2.transform.Translate(movementSide.x * 0.9f, 0, 0);
        Layer1.transform.Translate(movementSide.x * 1f, 0, 0);

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
