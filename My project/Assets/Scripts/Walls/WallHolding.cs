using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallHolding : MonoBehaviour
{
    public Rigidbody r;
    public GameObject speler;
    public float heightBackToNormal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.transform.gameObject.tag == "wall")
        {

        
            r.mass = 0;
            Jumping otherScript = speler.GetComponent<Jumping>();
            otherScript.height = 0;
            
        }
    }

    void OnCollisionExit(Collision other)
    {
        Jumping otherScript = speler.GetComponent<Jumping>();
        r.mass = 1;
        otherScript.height = heightBackToNormal;
    }
}
