using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 2f;
    public float rotati = 1f;

    Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveInput = Input.GetAxis("Horizontal");

        //rb.velocity = new Vector2(moveInput * speed, rb.velocity.y) ;
        transform.Rotate(Vector3.back, moveInput*speed);


    }
}
