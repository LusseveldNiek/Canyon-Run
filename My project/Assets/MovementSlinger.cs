using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSlinger : MonoBehaviour
{
    public Vector3 v;
    public float time;
    public float timeObstakel;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        v.x = v.x + timeObstakel;
        transform.Rotate(v);
        time += Time.deltaTime;
        if(time > 1)
        {
            time = 0;
            timeObstakel += 1;
        }
    }
}
