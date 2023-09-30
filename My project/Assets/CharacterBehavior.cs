using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehavior : MonoBehaviour
{
    public float speed;
    public float vInput;
    public float hInput;

    public float jumpForce;

    private bool isOnGround = true;


    public Rigidbody playerRb;
    public Animator playerAnim;
    
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
        
        
        transform.Translate(Vector3.forward * (Time.deltaTime * speed * hInput * -1));

        if (hInput < 0)
        {
            playerAnim.SetFloat("Spd", -hInput);
        }
        else
        {
            playerAnim.SetFloat("Spd", hInput);
        }
        
        
        //Another solution to get player Animator to work
        /*if (hInput != 0)
        {
            playerAnim.SetBool("isWalking", true);
        }
        else if (hInput > 0.5)
        {
            playerAnim.SetBool("isRunning", true);
            playerAnim.SetBool("isRunning", false);
        }
        else
        {
            playerAnim.SetBool("isWalking", false);
        }
        */
        
        

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.velocity = Vector3.up * jumpForce;
            isOnGround = false;
            
        }
        
        playerAnim.SetBool("Grounded", isOnGround);

        //print(hInput);

    }
    
    private void OnCollisionEnter(Collision other)
    {
        //Checks if the Player is on the ground
        if (other.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            Debug.Log("Grounded");
        }
    }

}
