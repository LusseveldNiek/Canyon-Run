using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStone : MonoBehaviour
{
    public float spawnTime;
    public GameObject[] myObjects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int randomIndex = Random.Range(0, myObjects.Length);
        spawnTime += Time.deltaTime;
        if(spawnTime > 5)
        {
            GameObject instantiatedObject = Instantiate(myObjects[randomIndex], transform.position, Quaternion.identity) as GameObject;
            spawnTime = 0;
        }
        
    
        
 
        


    }
}
