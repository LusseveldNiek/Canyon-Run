using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallHolding : MonoBehaviour
{
    public Rigidbody r;
    public GameObject speler;
    public float heightBackToNormal;
    public float yPosition;
    public float force;
    public float forceUp;
    public float yPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        
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

        
            Jumping otherScript = speler.GetComponent<Jumping>();
            otherScript.height = heightBackToNormal;
            r.useGravity = true;
        }

        if(other.transform.gameObject.tag == "wallRight")
        {

        
            Jumping otherScript = speler.GetComponent<Jumping>();
            otherScript.height = heightBackToNormal;
            r.useGravity = true;
        }

    }

    
     
}
