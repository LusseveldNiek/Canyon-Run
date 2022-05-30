using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CounterScript : MonoBehaviour
{
    public float counterFloat;
    public Text t;
    // Start is called before the first frame update
    void Start()
    {
       t = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
       GameObject respawn = GameObject.Find("RespawnPlatform");
       Spawn spawn = respawn.GetComponent<Spawn>();
       counterFloat = spawn.counter;
       t.text = counterFloat.ToString("f0");
    }
}
