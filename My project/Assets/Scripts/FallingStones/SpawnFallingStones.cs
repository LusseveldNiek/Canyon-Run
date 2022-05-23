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
        int x = Random.Range(9, 9);
        int y = Random.Range(12, 12);
        int z = Random.Range(17, 17);
        time += Time.deltaTime;
        if(time > 3)
        {
            time = 0;
            GameObject fallingStonePrefab = Instantiate(fallingStone, transform.position = new Vector3(x, y, z), fallingStone.transform.rotation);
        }
    }
}
