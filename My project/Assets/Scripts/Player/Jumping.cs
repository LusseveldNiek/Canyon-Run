using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
   public Vector3 v;
   public float height;
   Rigidbody rb;
   public bool isGrounded;
   public RaycastHit hit;
   public float distance;
   // Start is called before the first frame update
   void Start()
   {
       rb = GetComponent<Rigidbody>();
       v = new Vector3(0.0f, 5.0f, 0.0f);
   }

   void Update() 
   {

       if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
       {
           rb.AddForce(v * height, ForceMode.Impulse);
           isGrounded = false;
       }

       if(Physics.Raycast(transform.position, -transform.up, out hit, distance))
       {
           isGrounded = true;
       }

       else
       {
              isGrounded = false;
       }
   }
}
