using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public bool secondSpawn;
    public GameObject player;
    public GameObject spawnLocation;
    private GameObject rspwnPlatform;
    public bool respawning;
    // Start is called before the first frame update
    void Start()
    {
        rspwnPlatform = GameObject.Find("RespawnPlatform");
        respawning = rspwnPlatform.GetComponent<Spawn>().respawn;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if(secondSpawn == true)
        {
            if(collision.gameObject.tag == "Player")
            {
                Instantiate(player, spawnLocation.transform.position, spawnLocation.transform.rotation);
                secondSpawn = false;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            secondSpawn = true;
            
        }
    }

}
