using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiaanVasthouden : MonoBehaviour
{
    
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    public void OnTriggerStay(Collider other)
    {
        
        if(other.gameObject.tag == "Player")
        {
            if(Input.GetButton("Fire1"))
            {
                other.gameObject.transform.position = transform.position;
            }   
        }

      
    }

    public void Update()
    {
       

        
    }
}
