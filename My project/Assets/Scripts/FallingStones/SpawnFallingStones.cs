using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFallingStones : MonoBehaviour
{
    public float time;
    public GameObject fallingStone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int x = Random.Range(7, 11);
        int y = Random.Range(14, 14);
        int z = Random.Range(8, 28);
        time += Time.deltaTime;
        if(time > 1)
        {
            GameObject fallingStonePrefab = Instantiate(fallingStone, transform.position = new Vector3(x, y, z), fallingStone.transform.rotation);
            time = 0;
            
        }
    }
}
