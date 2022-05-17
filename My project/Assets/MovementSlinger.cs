using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSlinger : MonoBehaviour
{
    public Vector3 v;
    public float time;
    public float timeObstakel;
    public float speed;
    public bool left;
    public float timeLeft;
   
   
    // Start is called before the first frame update
    void Start()
    {
        left = false;
    }

    // Update is called once per frame
    void Update()
    {
        v.x = v.x + timeObstakel;
        transform.Rotate(v);
        time += Time.deltaTime;
        if(time > 1)
        {
            if(left == false)
            {

            
                time = 0;
                timeObstakel += speed;
            }
        }


        if(timeObstakel > 0.0004)
        {
            left = true;
        
            
        }

        if(left == true)
        {   
            timeLeft += Time.deltaTime;
            if(timeLeft > 1)
            {
                timeLeft = 0;
                timeObstakel -= speed;
                if(timeObstakel < -0.004)
                {
                    left = false;
                }
            }
        }
        
    }
}
