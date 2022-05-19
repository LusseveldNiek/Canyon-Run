using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 v;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        v.x = Input.GetAxis("Horizontal");
        v.z = Input.GetAxis("Vertical");
        transform.Translate(v * speed);


    }
}
