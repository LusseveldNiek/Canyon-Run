using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRunning : MonoBehaviour
{
    public Rigidbody r;
    public GameObject speler;
    public float heightBackToNormal;
    public float force;
    public float forceUp;
    public float yPos;
    public float speed;
    public float rotationSpeed;
    public float rotationReset;
    public float moving;
    public Quaternion startRotation;
    public float time;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        moving = 5;
    }

    // Update is called once per frame
    void Update()
    {
       
        Movement movement = GetComponent<Movement>();
        movement.speed = moving;
        
    }

    void OnTriggerEnter(Collider other)
    {
        
        if(other.transform.gameObject.tag == "wallLeft")
        {
            yPos = Mathf.Clamp(transform.position.y, transform.position.y, transform.position.y);
        }

        if(other.transform.gameObject.tag == "wallRight")
        {
            yPos = Mathf.Clamp(transform.position.y, transform.position.y, transform.position.y);
        }
    }
    void OnTriggerStay(Collider other)
    {
        if(other.transform.gameObject.tag == "wallLeft")
        {   
            animator.SetTrigger("WallLeft");
            animator.SetBool("IsGrounded", true);
            moving = 0;
            rotationReset += Time.deltaTime;
            if(rotationReset < 1)
            {
                transform.Rotate(-Vector3.forward * rotationSpeed * Time.deltaTime);
            }
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
            Jumping otherScript = speler.GetComponent<Jumping>();
            otherScript.height = 0;
            r.useGravity = false;
            if(Input.GetButtonDown("Jump"))
            {
                r.AddForce(transform.right * force);
                r.AddForce(transform.up * forceUp);
            }
        }

        if(other.transform.gameObject.tag == "wallRight")
        {
            animator.SetTrigger("WallRight");
            animator.SetBool("IsGrounded", true);
            moving = 0;
            rotationReset += Time.deltaTime;
            if(rotationReset < 2)
            {
                transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
            }
            
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
            Jumping otherScript = speler.GetComponent<Jumping>();
            otherScript.height = 0;
            r.useGravity = false;
            if(Input.GetButtonDown("Jump"))
            {
                r.AddForce(transform.right * -force);
                r.AddForce(transform.up * forceUp);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.transform.gameObject.tag == "wallLeft")
        {
            animator.ResetTrigger("WallLeft");
            moving = 5;
            rotationReset = 0;
            Jumping otherScript = speler.GetComponent<Jumping>();
            otherScript.height = heightBackToNormal;
            r.useGravity = true;
        }

        if(other.transform.gameObject.tag == "wallRight")
        {
            animator.ResetTrigger("WallRight");
            moving = 5;
            rotationReset = 0;
            transform.rotation = Quaternion.Slerp(startRotation, Quaternion.identity, time);
            time += Time.deltaTime;
            Jumping otherScript = speler.GetComponent<Jumping>();
            otherScript.height = heightBackToNormal;
            r.useGravity = true;
        }
        
        

      
    }

    
     
}
