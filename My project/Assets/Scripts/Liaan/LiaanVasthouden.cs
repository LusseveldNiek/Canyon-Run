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
        Animator animator = player.GetComponentInChildren<Animator>();
        if(other.gameObject.tag == "Player")
        {
            if(Input.GetButton("Fire1"))
            {
                other.gameObject.transform.position = gameObject.GetComponent<Collider>().transform.position;
                animator.SetBool("Holding", true);
            }  
            
            else
            {
                animator.SetBool("Holding", false);
            }

        }

      
    }

   
}
