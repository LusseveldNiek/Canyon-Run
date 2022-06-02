using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallHolding : MonoBehaviour
{
    public Rigidbody r;
    public GameObject speler;
    public float heightBackToNormal;
    public float yPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        
    }

    void OnTriggerStay(Collider other)
    {
        if(other.transform.gameObject.tag == "wall")
        {
            //transform.position.y = Mathf.Clamp(transform.position.y, 0, 0);
            Jumping otherScript = speler.GetComponent<Jumping>();
            otherScript.height = 0;
            r.useGravity = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.transform.gameObject.tag == "wall")
        {

        
            Jumping otherScript = speler.GetComponent<Jumping>();
            otherScript.height = heightBackToNormal;
            r.useGravity = true;
        }

    }
}
