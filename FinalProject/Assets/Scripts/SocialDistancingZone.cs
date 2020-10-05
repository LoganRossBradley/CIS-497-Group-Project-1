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
    private Animator animator;

    // Update is called once per frame
    void Update()
    {
        animator = GetComponentInChildren<Animator>();
        goalRef = GameObject.FindGameObjectWithTag("Goal").GetComponent<GoalManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Enemy") && !goalRef.gameOver)
        {
            animator.SetFloat("Speed_f", 0);
            Debug.Log("Game Over");
            goalRef.gameOver = true;
            goalRef.gotCorona = true;
        }
        
    }

}