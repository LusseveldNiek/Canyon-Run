using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSlinger : MonoBehaviour
{
    public float speed;
    public float time;
    public float timeRight;
    
   
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time < 3)
        {
             transform.Rotate(Vector3.right * speed * Time.deltaTime);
        }

        if(time > 3)
        {
            transform.Rotate(Vector3.left * speed * Time.deltaTime);
            timeRight += Time.deltaTime;
            if(timeRight > 3)
            {
                timeRight = 0;
                time = 0;
            }
        }


        
        
    }
}
