using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public bool respawn;
    public GameObject player;
    public GameObject spawn;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.transform.gameObject);
            respawn = true;
            
        }
    }   
    
    
    void Update()
    {
        if(respawn == true)
        {
            Instantiate(player, spawn.transform.position, spawn.transform.rotation);
            respawn = false;
        }
    }
}
