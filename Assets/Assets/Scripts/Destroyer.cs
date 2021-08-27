using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
   
    //This will simply destroy the Enemy gameObjects that were dodged by the player and were not destroyed 
    // It's basically a wall of death for enemies 
    //The Score will not be incremented if the enemy is destroyed by this object
    //This script will also destroy the excess Blasters from the player that failed to destroy the enemy and were not destroyed
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Blaster")
        {
            Destroy(collision.gameObject);
        }
    }
}
