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
        speed += Time.deltaTime * 14;
        time += Time.deltaTime;
        if(time < 7)
        {
             
             transform.Rotate(Vector3.right * speed * Time.deltaTime);
        }
        
        if(time > 7)
        {
            if(reset == true)
            {
                speed = 0;
                reset = false;
            }
            
           
        }

        if(reset == false)
        {
            transform.Rotate(Vector3.left * speed * Time.deltaTime);
            if(time > 14)
            {
                time = 0;
                speed = 0;
                reset = true;
            }
        }


        
        
    }
}
