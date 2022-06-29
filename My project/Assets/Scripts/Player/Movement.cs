using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 v;
    public float speed;
    public bool stand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jumping jumping = GetComponent<Jumping>();
        stand = jumping.isGrounded;
        transform.Translate(v * speed * Time.deltaTime); 
        if(stand == true)
        {
        v.x = Input.GetAxis("Horizontal");
        v.z = Input.GetAxis("Vertical");
        }
       
    }

    
       

    

   

    

    
}
