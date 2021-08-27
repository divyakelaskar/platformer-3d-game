using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float shipSpeed=10;             //Ships speed
    Vector3 position;                       

    public float maxPos =0;                 //Movement Limitation

    public Rigidbody blaster;                    //Bullet
    public Transform Spawnpt;               //Bullet Spawn Point
    


    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
      
    }

    // Update is called once per frame
    void Update()
    {
        position.x += Input.GetAxis("Horizontal") * shipSpeed * Time.deltaTime;         // Left-Right Arrow Keys and A and D keys
        position.z += Input.GetAxis("Vertical") * shipSpeed * Time.deltaTime;           // Up-Down Arrow Keys and W and S keys

        transform.position = position;                                                  //Updates the position

        position.x = Mathf.Clamp(position.x, -9f, 9f);                          //Freezes the movement on x-axis
        position.z = Mathf.Clamp(position.z, -12f, 12f);

        shoot();


        if (Input.GetKeyDown(KeyCode.P)) {                  //True after P key is pressed

            Pause();
        }

    }

    void shoot()
    {
        
        if (Input.GetButtonDown("Fire1"))           //Mouse Left Click and Left Control 
        {

            Rigidbody cln;
            cln = (Rigidbody)Instantiate(blaster, Spawnpt.position, blaster.rotation);
            cln.velocity = Spawnpt.TransformDirection(Vector3.forward * 5);
           
        }
    }

    //Pauses the Game
    void Pause() {

        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;

        }
        else if (Time.timeScale == 0) {
            Time.timeScale = 1;
        }

    }


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "EnemyShip")
        {
           
            Destroy(this.gameObject);
                                     

        }
    }


}
