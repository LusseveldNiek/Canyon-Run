using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
   public Vector3 v;
   public float height;
   Rigidbody rb;
   public bool isGrounded;
   // Start is called before the first frame update
   void Start()
   {
       rb = GetComponent<Rigidbody>();
       v = new Vector3(0.0f, 5.0f, 0.0f);
   }

   void OnCollisionStay()
   {
       isGrounded = true;
   }

   void OnCollisionExit()
   {
       isGrounded = false;
   }

   void OnCollisionEnter()
   {
       isGrounded = true;
   }

   void Update() 
   {
       if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
       {
           rb.AddForce(v * height, ForceMode.Impulse);
           isGrounded = false;
       }
   }
}
