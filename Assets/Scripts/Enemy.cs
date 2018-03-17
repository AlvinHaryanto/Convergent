using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;

    public Transform target;
    private int wavepointIndex = 0;

    private void Start()
    {
        target = Waypoints.points[0];
    }
    private void FixedUpdate()
    {
        Vector3 dir = target.position - transform.position;
        
        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            //GetNextWaypoint();
            transform.Translate(dir.normalized * 0, Space.World);
        }
        else transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

    }

    void GetNextWaypoint()
    {
        //if (wavepointIndex >= Waypoints.points.Length - 1)
        // {
            //transform.Translate(dir.normalized * 0);
        //    return;
        //}
        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];

    }

}

