using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerupBehavior : MonoBehaviour
{

    public UnityEvent collectCoin;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            collectCoin.Invoke();
            Destroy(gameObject);
            
            
        }
    }
}
