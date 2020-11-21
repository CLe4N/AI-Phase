using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot_Sensor : MonoBehaviour
{
    [SerializeField]float DectectDis;
    Transform Player;
    public bool Detected;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform; // find gameobject with tag "Player" and access transform component
    }

    void Update()
    {
        VisionCheck();
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red; // change gizmo color to red
        Gizmos.DrawWireSphere (transform.position, DectectDis); // draw spehere
    }

    void VisionCheck()
    {
        if(Vector3.Distance(transform.position,Player.position)< DectectDis) // if player distance is closer than DectectDis
        {
            Detected = true; // Detected = true
        }
        else
        {
            Detected = false; // Detected = false
        }
    }
}
