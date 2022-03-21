using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public test testobj;
    //public staticTest test;
    public float speed = 5.0f;
    public float turnSpeed = 3.0f;
    private string leftkey = "A";

    private string rightkey = "D";

    private string forward = "W";

    private string backward = "S";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //testobj.playerSpeed = 2;
        turnCar();
    }

    private void turnCar()
    {
 
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * turnSpeed);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
        }
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * turnSpeed);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * turnSpeed);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "box")
        {
            staticTest.addScore(3);
            print(staticTest.score);
        }
    }
}
