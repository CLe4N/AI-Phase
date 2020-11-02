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
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        VisionCheck();
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere (transform.position, DectectDis);
    }

    void VisionCheck()
    {
        if(Vector3.Distance(transform.position,Player.position)< DectectDis)
        {
            Detected = true;
        }
        else
        {
            Detected = false;
        }
    }
}
