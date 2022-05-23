using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingStones : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed += Time.deltaTime;
        transform.transform.localScale = new Vector3(speed, speed, speed);
        
    }

    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}
