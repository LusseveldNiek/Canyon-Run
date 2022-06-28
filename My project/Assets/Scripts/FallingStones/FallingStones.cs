using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingStones : MonoBehaviour
{
    public float speed;
    public float growSpeed;
    public GameObject exp;
    // Start is called before the first frame update
    void Start()
    {
        speed = 30;
    }

    // Update is called once per frame
    void Update()
    {
      
        speed += Time.deltaTime * 10;
        transform.localScale = new Vector3(speed, speed, speed);
        
        
       
    }

    void OnCollisionEnter(Collision other)
    {
        
        Destroy(gameObject);
        GameObject _exp = Instantiate(exp, other.transform.position, transform.rotation);
        Destroy(_exp, 3.0f);
        
    }
}
