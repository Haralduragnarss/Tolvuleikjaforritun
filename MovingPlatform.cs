using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform: MonoBehaviour
{
    [SerializeField] GameObject[] waypoints; // Gameobject búið til fyrir waypointana sem láta platformið hreyfast
    int CurrentWayPointIndex = 0; // Núverandi waypoint núllstillt
    [SerializeField] float speed = 1f; // Hraðinn á platforminu settur sem 1

    void Update()
    {
        if (Vector3.Distance(transform.position, waypoints[CurrentWayPointIndex].transform.position) < .1f) // Ef að bilið á milli waypointana tveggja er meira en 0.1 þá færast þeir nær hvor öðrum
        {
            CurrentWayPointIndex++; // Waypontið bætir við sig einn til að færast nær
            if (CurrentWayPointIndex >= waypoints.Length)
            {
                CurrentWayPointIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[CurrentWayPointIndex].transform.position, speed * Time.deltaTime); // Hérna fær hreyfingin sjálf framm, kallað er á MoveTowards fallið til þess
    }
}
