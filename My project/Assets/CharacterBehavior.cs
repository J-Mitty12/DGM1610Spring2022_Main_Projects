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
    
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
        
        
        transform.Translate(Vector3.right * (Time.deltaTime * speed * hInput));

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.velocity = Vector3.up * jumpForce;
            isOnGround = false;
            
        }

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
