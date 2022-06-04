using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "finish")
        {
            LoadFinish();
        }
    }

    public void LoadFinish()
    {
        SceneManager.LoadScene("FinishScreen");
    }
}
