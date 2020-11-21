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
        Botagent = GetComponent<NavMeshAgent>(); // access NavMeshAgent and Bot_Sensor component
        Sensor = GetComponent<Bot_Sensor>();
        Player = GameObject.FindGameObjectWithTag("Player").transform; // find gameobejct with tag "Player"
        
    }

    void Update()
    {
        if (Sensor.Detected == false) // if player is not detect
        {
            Pratoling(); // call method "Pratoling"
        }
        else
        {
            Chasing(); // call method "Chasing"
        }
    }

    void Pratoling()
    {
        Botagent.destination = WayPoint[WayPointCount].position; // go to waypoint[WayPointCount]
        if (Vector3.Distance(transform.position, WayPoint[WayPointCount].position) < 0.1f) // if this gameobject is closer to waypoint[WayPointCount] than 0.1
        {
            WayPointCount += 1; // WayPointCount increase by 1
            if(WayPointCount >= WayPoint.Length) // if WayPointCount is more than WayPoint[] Length
            {
                WayPointCount = 0; // WayPointCount = 0
            }
        }
    }

    void Chasing()
    {
        Botagent.destination = Player.position; // go to player
    }
}
