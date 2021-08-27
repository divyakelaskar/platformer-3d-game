using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{


    public int scoreValue;

    
    

    // Start is called before the first frame update
    void Start()
    {
       
    

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            ScoreManager.score += scoreValue;
            Destroy(this.gameObject);
           

        }
    }
}
