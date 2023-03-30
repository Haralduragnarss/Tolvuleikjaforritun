using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform: MonoBehaviour
{
    [SerializeField] GameObject[] waypoints; // Gameobject b�i� til fyrir waypointana sem l�ta platformi� hreyfast
    int CurrentWayPointIndex = 0; // N�verandi waypoint n�llstillt
    [SerializeField] float speed = 1f; // Hra�inn � platforminu settur sem 1

    void Update()
    {
        if (Vector3.Distance(transform.position, waypoints[CurrentWayPointIndex].transform.position) < .1f) // Ef a� bili� � milli waypointana tveggja er meira en 0.1 �� f�rast �eir n�r hvor ��rum
        {
            CurrentWayPointIndex++; // Wayponti� b�tir vi� sig einn til a� f�rast n�r
            if (CurrentWayPointIndex >= waypoints.Length)
            {
                CurrentWayPointIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[CurrentWayPointIndex].transform.position, speed * Time.deltaTime); // H�rna f�r hreyfingin sj�lf framm, kalla� er � MoveTowards falli� til �ess
    }
}
