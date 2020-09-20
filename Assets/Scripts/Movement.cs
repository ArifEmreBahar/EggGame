using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float sideSpeed = 500f;
    public float maxSpeed = 2f;
    public float groundJumpStrength = 1.5f;
    public float groundBackJumpStrength = 7f;
    public float waterJumpStrength = 1f;
    public float waterBackJumpStrength = 4f;
    public float jumpStrength = 3f;
    public float maxJumpStrength = 6f;
    public float jumpStrengthMultiplier = 3f;

    /*private float dashTime;
    public float startDashTime;
    public float dashSpeed;*/

    private string spacePressPoint;
    private Rigidbody2D Player;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        Player = GetComponent<Rigidbody2D>();

        //dashTime = startDashTime;
    }

    void FixedUpdate()
    {
        
        if (isMaximumSpeed(maxSpeed))
        {
            MovePlayer();
        }
        
        if (Input.GetKey(KeyCode.K))
        {
            if (jumpStrength < maxJumpStrength)
            {
                jumpStrength += (Time.deltaTime * jumpStrengthMultiplier);
            }
            /*if (Input.GetKeyDown(KeyCode.Space)) {
                spacePressPoint = Player.transform.eulerAngles.z;
            }*/
        }
        else if (Input.GetKeyUp(KeyCode.K))
        {
            JumpPlayer("up");
            //dashPlayer();
        }
        if (Input.GetKeyUp(KeyCode.L))
        {
            JumpPlayer("down");
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
    private bool isNoJump()
    {
        return transform.Find("CollisionDetect").GetComponent<CollisionDetect>().isNoJump;
    }

    private void JumpPlayer(string spacePressPoint)
    {

        if (isGruond() && !isNoJump())
        {
            if (spacePressPoint == "up")
            { 
                Player.velocity = Player.GetRelativeVector(Vector2.up) * jumpStrength * groundJumpStrength;
                jumpStrength = 3f;
            }
            if (spacePressPoint == "down")
            {
                Player.velocity = Player.GetRelativeVector(Vector2.down) * groundBackJumpStrength;
                jumpStrength = 3f;
            }
        }
        if (isWater() && !isNoJump())
        {
            if (spacePressPoint == "up")
            {
                Player.velocity = Player.GetRelativeVector(Vector2.up) * jumpStrength * waterJumpStrength;
                jumpStrength = 3f;
            }
            if (spacePressPoint == "down")
            {
                Player.velocity = Player.GetRelativeVector(Vector2.down) * waterBackJumpStrength;
                jumpStrength = 3f;
            }
        }
    }
    
    /*private void dashPlayer() {

        if (dashTime <= 0)
        {
            dashTime = startDashTime;
            Player.velocity = Vector2.zero;
        }
        else {
            dashTime -= Time.deltaTime;
            Player.velocity = Vector2.right * dashSpeed;
        }
    }*/
}
