/*
 * James Difiglio
 * Project 1
 * Manages social distancing zones throwing game overs 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialDistancingZone : MonoBehaviour
{

    private GoalManager goalRef;
    

    // Update is called once per frame
    void Update()
    {
        goalRef = GameObject.FindGameObjectWithTag("Goal").GetComponent<GoalManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Enemy") && !goalRef.gameOver)
        {
            Debug.Log("Game Over");
            goalRef.gameOver = true;
            goalRef.gotCorona = true;
        }
        
    }

}