using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 2.0f;
    //public AudioSource jumpAudio;
   // public Button jumpButton;
    public bool isGrounded;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }
    void OnCollisionExit()
    {
        isGrounded = false;
    }
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded==true)
        {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
         //   jumpAudio.Play();

        }  
    }

    public void JumpTwo() {

        rb.AddForce(jump * jumpForce, ForceMode.Impulse);
        isGrounded = false;
      //  jumpAudio.Play();

    }
}
