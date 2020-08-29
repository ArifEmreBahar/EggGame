using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float sideSpeed = 500f;
    public float backJumpSpeed = 8f;
    public float maxSpeed = 2f;
    private float minJumpStrength = 5f;
    public float maxJumpStrength = 10f;
    public float jumpStrengthmultiplier = 5f;

    private float spacePressPoint;
    private Rigidbody2D Player;
    private bool isJumped;

    void Start()
    {
        Player = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        
        if (isMaximumSpeed(maxSpeed))
        {
            MovePlayer();
        }
        
        if (Input.GetKey(KeyCode.Space))
        {
            if (minJumpStrength < maxJumpStrength)
            {
                minJumpStrength += (Time.deltaTime * jumpStrengthmultiplier);
            }
            if (Input.GetKeyDown(KeyCode.Space)) {
                spacePressPoint = Player.transform.eulerAngles.z;
            }
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            JumpPlayer(spacePressPoint);
        }
    }

    private void MovePlayer()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        Player.AddForce(moveInput * sideSpeed * Time.deltaTime);
    }

    private bool isMaximumSpeed(float maximumSpeed)
    {
        if (Player.velocity.magnitude < maximumSpeed)
        {
            return true;
        }
        else return false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJumped = true;
        }
        else { isJumped = false; }
    } 

    private void JumpPlayer(float spacePressPoint)
    {
       
        if (isJumped) { 
            if (spacePressPoint < 90f || spacePressPoint > 270f)
            {
                Player.velocity = Player.GetRelativeVector(Vector2.up) * minJumpStrength;
                minJumpStrength = 5f;
            }
            else
            {
                Player.velocity = Player.GetRelativeVector(Vector2.down) * backJumpSpeed;
            }
        }
    }
}
