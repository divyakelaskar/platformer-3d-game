using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float shipSpeed = 4f;                  //Enemy Ships Speed

    public GameObject menuDisplay;
   

    // Start is called before the first frame update
    void Start()
    {
        menuDisplay.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * shipSpeed * Time.deltaTime);
    
    }


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")                       //This will Kill the Player if the Player Collides with this Enemy Game Object
        {
            Destroy(collision.gameObject);
            menuDisplay.SetActive(true);

        }

      /*  if (                                                           //Simply remove this condition to let it go through multiple enemies
            Destroy(collision.gameObject);
         8   
        }*/
    }


    
}
