/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Behavior : MonoBehaviour
{

    [Header ("Speed info")]
    public float speed = 10f;
    public float maxFallSpeed = -30f;
    [Header ("Crouch info")]
    public float crouchPercentOfHeight = 0.5f;
    public bool isCrouching {get; private set;}
    [Header ("Jump info")]
    public float jumpForce = 5f;
    public bool hasJumped {get; private set;}

    private Vector2 standColliderSize;
    private Vector2 standColliderOffset;
    private Vector2 crouchColliderSize;
    private Vector2 crouchColliderOffset;






    void Awake(){
      rigidBody = this.GetComponent<Rigidbody2D>();
      //playerCollider = this.GetComponent<BoxCollider2D>();
      //playerControls = this.GetComponent<PlayerControls>();

      standColliderSize = playerCollider.size;
      standColliderOffset = playerCollider.offset;

      crouchColliderSize = new Vecto2(standColliderSize.x, standColliderSize.y * crouchPercentOfHeight);
      crouchColliderOffset = new Vecto2(standColliderOffset.x, standColliderOffset.y * crouchPercentOfHeight);

      hasJumped = isCrouching = false;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
      //velocityX = playerControls.playerDirection.X * speed;
      StandUp();
      Crouch();
      JumPressed();
      Jump();
      rigiBody.velocity = new Vector2(velocityX, rigiBody.velocity.y);

    }

    private void JumPressed(){
      if (Input.GetKeyDown (KeyCode.Space))
      {
        jumpPressed = true;
      }
    }

    private void Crouch(){
      //if(playerControls.crouchingPressed){
        isCrouching = true;
        playerCollider.size = crouchColliderSize;
        playerCollider.offset = crouchColliderOffset;
      }
    }
    private void StandUp(){
      //if(!playerControls.crouchingPressed){
        isCrouching = false;
        playerCollider.size = standColliderSize;
        playerCollider.offset = standColliderOffset;
      }
    }

    private void Jump(){
      if(!playerControls.jumpPressed){
        hasJumped = false;
      }
      if(playerControls.jumpPressed){
        hasJumped = true;
        rigiBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
      }
    }

}*/
