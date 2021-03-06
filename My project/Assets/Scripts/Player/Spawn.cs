using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public bool respawn;
    public GameObject player;
    public GameObject spawn;
    public float counter;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.transform.gameObject);
            respawn = true;
            counter += 1;
            
        }

        if(collision.gameObject.tag == "RollendeBallen")
        {
            Destroy(collision.transform.gameObject);
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
