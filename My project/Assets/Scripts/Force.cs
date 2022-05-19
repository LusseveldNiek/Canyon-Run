using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    public GameObject exp;
    public float expForce;
    public float radius;
    void Start()
    {
        
    }

    void Update()
    {
       
    }

    void OnCollisionEnter(Collision other)
    {
        GameObject _exp = Instantiate(exp, transform.position, transform.rotation);
        Destroy(_exp, 3.0f);
        KnockBack();
    }

    void KnockBack()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider nearyby in colliders)
        {
            Rigidbody rigg = nearyby.GetComponent<Rigidbody>();
            if(rigg != null)
            {
                rigg.AddExplosionForce(expForce, transform.position, radius);
            }
        }
    }
}
