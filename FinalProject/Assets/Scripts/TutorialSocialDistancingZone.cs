/*
 * James Difiglio, Benjamin Schuster
 * Social Distancing Simulator (Project 1-3)
 * Manages social distancing zones moving player back in Tutorial 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialSocialDistancingZone : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Enemy"))
        {
            transform.position = new Vector3(20f, 1.49f, -27.25f);
        }
        
    }

}