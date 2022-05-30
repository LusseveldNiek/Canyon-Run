using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour
{
    public Text t;
    public float tijd;
    // Start is called before the first frame update
    void Start()
    {
       t = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
       tijd += Time.deltaTime;
       t.text = tijd.ToString("f0");
       

    }
}
