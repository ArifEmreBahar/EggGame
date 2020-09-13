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
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
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

        /*
        if (isJumped())
        {
            anim.SetBool("isJumping", true);
        }
        else { anim.SetBool("isJumping", false); }*/
    }

    private void MovePlayer()
    {
        if (isGruond())
        {  
            Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
            Player.AddForce(moveInput * sideSpeed * Time.deltaTime);
        }
        if(isWater()) {
            Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
            Player.AddTorque(-moveInput.x * sideSpeed * Time.deltaTime);
        }
    }

    private bool isMaximumSpeed(float maximumSpeed)
    {
        if (Player.velocity.magnitude < maximumSpeed)
        {
            return true;
        }
        else return false;
    }

    private bool isGruond()
    {
        return transform.Find("CollisionDetect").GetComponent<CollisionDetect>().isGruond;
    }
    private bool isWater()
    {
        return transform.Find("CollisionDetect").GetComponent<CollisionDetect>().isWater;
    }

    private void JumpPlayer(float spacePressPoint)
    {
       
        if (isGruond()) { 
            if (spacePressPoint < 90f || spacePressPoint > 270f)
            {
                Player.velocity = Player.GetRelativeVector(Vector2.up) * minJumpStrength;
                minJumpStrength = 5f;
            }
            else
            {
                Player.velocity = Player.GetRelativeVector(Vector2.down) * backJumpSpeed;
                minJumpStrength = 5f;
            }
        }
    }
}
