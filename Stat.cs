using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat : MonoBehaviour
{
    TextMesh txt;
    Bot_Sensor sensor;
    Transform botPos;
    void Start()
    {
        txt = GetComponent<TextMesh>();
        sensor = GetComponentInParent<Bot_Sensor>();
        botPos = GameObject.Find("Bot").transform;
    }

    
    void Update()
    {
        transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.forward, Camera.main.transform.rotation * Vector3.up);
        if (sensor.Detected == true)
        {
            txt.text = "Chasing";
        }
        else
        {
            txt.text = "Pratoling";
        }
    }
}
