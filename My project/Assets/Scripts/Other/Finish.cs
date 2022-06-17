using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public float time;
    public bool sceneChanging;
    public float moving;
    public Transform cam;

    void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "finish")
        {
        
        
            cam.Rotate(-20, 7, 1);
            cam.position = new Vector3(1, 1, 72);
            sceneChanging = true;
        }
        
    }

    void Start()
    {
        sceneChanging = false;
    }

    void Update()
    {

       
        if(sceneChanging == true)
        {
            Movement movement = GetComponent<Movement>();
            movement.speed = moving;
            moving = 0;
            transform.Translate(Vector3.forward * Time.deltaTime);
            time += Time.deltaTime;
            if(time > 3)
            {
                sceneChanging = false;
                LoadFinish();
                time = 0;
            }
        }
    }

    public void LoadFinish()
    {
        SceneManager.LoadScene("FinishScreen");
    }
}
