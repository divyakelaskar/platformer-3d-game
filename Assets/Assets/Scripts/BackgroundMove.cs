using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{

    public float speed;                         //Speed Variable for the background movement
    Vector2 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        offset = new Vector2(Time.time * speed,0 );                               //Direction in which we want the background to move
        GetComponent<Renderer>().material.mainTextureOffset = offset;              //The material reference 
        
    }
}
