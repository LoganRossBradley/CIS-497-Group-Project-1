/*
 * James Difiglio
 * Social Distancing Simulator (Project 1-3)
 * Manages social distancing zones throwing game overs 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialDistancingZone : MonoBehaviour
{

    private GoalManager goalRef;
    private Animator animator;

    private AudioSource playerAudio;
    public AudioClip cough;

    private void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

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
            playerAudio.PlayOneShot(cough);
        }
        
    }

}