using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{

    public float movementSpeed;



    //Update is called once per frame
    /* void FixedUpdate()
     {

         if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey("w"))
         {
             transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed * 2.5f;
         }
         else if (Input.GetKey("w") && !Input.GetKey(KeyCode.LeftShift))
         {
             transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
         }
         else if (Input.GetKey("s"))
         {
             transform.position -= transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
         }

         if (Input.GetKey("a") && !Input.GetKey("d"))
         {
             transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
         }
         else if (Input.GetKey("d") && !Input.GetKey("a"))
         {
             transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
         }
     }*/

    public Animator anim;
    private void Update()
    {
        float strafe = Input.GetAxis("Horizontal");
        float forward = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(strafe, 0, forward) * movementSpeed * Time.deltaTime );
        anim.SetFloat( "Forward" , forward);
        anim.SetFloat( "Right" , strafe);
    }  
}
