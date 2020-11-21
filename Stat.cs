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
        txt = GetComponent<TextMesh>(); // access TextMesh component
        sensor = GetComponentInParent<Bot_Sensor>(); // access Bot_Sensor component in parent
        botPos = GameObject.Find("Bot").transform; // find "Bot" and access transform component
    }

    
    void Update()
    {
        transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.forward, Camera.main.transform.rotation * Vector3.up);
        //rotate to main camera
        if (sensor.Detected == true) // if player is detected
        {
            txt.text = "Chasing"; // show text "Chasing"
        }
        else
        {
            txt.text = "Pratoling"; // show text "Pratoling"
        }
    }
}
