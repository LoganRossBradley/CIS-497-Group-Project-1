/*
 * Benjamin Schuster
 * Social Distancing Simulator (Project 1-3)
 * Rotates the compass so it will point towards the goal 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour
{
    public GameObject goal;
    public GameObject arrow;
    public float viewDistance;
    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        //Set the initial distance between player and goal
        distance = Vector3.Distance(transform.position, goal.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate compass to point towards the goal
        transform.LookAt(goal.transform);

        //Have the arrow disappear if the player is close enough to goal, reappear if strays too far from goal
        distance = Vector3.Distance(transform.position, goal.transform.position);
        if (distance <= viewDistance)
        {
            arrow.GetComponent<MeshRenderer>().enabled = false;
        }
        else
        {
            arrow.GetComponent<MeshRenderer>().enabled = true;
        }

    }
}
