using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSlinger : MonoBehaviour
{
    public float speed;
    public float time;
    public bool reset;
    
   
   
    // Start is called before the first frame update
    void Start()
    {
       reset = true;
    }

    // Update is called once per frame
    void Update()
    {
        speed += Time.deltaTime * 17;
        time += Time.deltaTime;
        if(time < 4)
        {
             
             transform.Rotate(Vector3.up * speed * Time.deltaTime);
        }
        
        if(time > 4)
        {
            if(reset == true)
            {
                speed = 0;
                reset = false;
            }
            
           
        }

        if(reset == false)
        {
            transform.Rotate(-Vector3.up * speed * Time.deltaTime);
            if(time > 8)
            {
                time = 0;
                speed = 0;
                reset = true;
            }
        }


        
        
    }
}
