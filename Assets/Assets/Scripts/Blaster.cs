using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blaster : MonoBehaviour                //This Script destroys the Enemies upon collision with the Blaster (Bullet) and Score is incremented by the assigned score value.
{

    public int scoreValue = 1;                      //Score Value 
    public int speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
        Destroy(this.gameObject,6);
    }


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            ScoreManager.score += scoreValue;                               //Score Manager is the reference to the ScoreManager Script with the score object 
           
        }
    }
}
