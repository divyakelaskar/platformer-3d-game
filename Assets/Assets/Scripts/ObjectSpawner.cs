using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    public GameObject[] ship;                               //Array of Objects that can be spawned randomly
    int objNo;
    public float maxPos = 10f;                             //Max spawn distance similar to the player bounderies
    public float delayTimer = 0.5f;                         // Time Pause between each spawn
    float timer;
    



    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        spawn();
        stopSpawn();
    }

    void spawn()
    {


        timer -= Time.deltaTime;

        if (timer <= 0)
        {

            Vector3 shipPos = new Vector3(Random.Range(24.94f, 0f), transform.position.y, transform.position.z);
            objNo = Random.Range(0, 1);
            Instantiate(ship[objNo], shipPos, transform.rotation);
            timer = delayTimer;
        }
    }

    void stopSpawn() {                                      //Function to Stop the Objects from Spawning after the Player is Dead
                                                            //This Will Simply Destroy the Spawn gameObject

        GameObject[] player;
        player = GameObject.FindGameObjectsWithTag("Player");

        if (player.Length == 0)
        {
            Destroy(gameObject);
        }
    }
}
    
