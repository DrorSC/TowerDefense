using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;

	// Use this for initialization
	void Start () {
        target = Waypoints.points[0];
	}
	
	// Update is called once per frame
	void Update () {
        // By substracting the x,y,z of our target with where we are, we get a vector of direction we need to go
        Vector3 direction = target.position - transform.position;
        // We normalize the vector so the only thing that controls our speed is our speed variable
        // We multiply by deltaTime to make sure the speed isnt depandant on frame rate alone (Time.deltaTime = time passed since last frame)
        transform.Translate(direction.normalized * speed *Time.deltaTime, Space.World);

        if(Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }
	}

    private void GetNextWaypoint()
    {
        if(wavepointIndex >= Waypoints.points.Length - 1)
        {
            Destroy(gameObject);
        } else
        {
            wavepointIndex++;
            target = Waypoints.points[wavepointIndex];
        }
    }
}
