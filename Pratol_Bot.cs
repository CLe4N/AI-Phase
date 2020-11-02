using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pratol_Bot : MonoBehaviour
{
    public Transform[] WayPoint;
    [SerializeField] int WayPointCount = 0;
    NavMeshAgent Botagent;
    Bot_Sensor Sensor;
    Transform Player;

    void Start()
    {
        Botagent = GetComponent<NavMeshAgent>();
        Sensor = GetComponent<Bot_Sensor>();
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Sensor.Detected == false)
        {
            Pratoling();
        }
        else
        {
            Chasing();
        }
    }

    void Pratoling()
    {
        Botagent.destination = WayPoint[WayPointCount].position;
        if (Vector3.Distance(transform.position, WayPoint[WayPointCount].position) < 0.1f)
        {
            WayPointCount += 1;
            if(WayPointCount >= WayPoint.Length)
            {
                WayPointCount = 0;
            }
        }
    }

    void Chasing()
    {
        Botagent.destination = Player.position;
    }
}
