﻿/*
 * James Difiglio, Benjamin Schuster, Jerod Lockhart
 * Social Distancing Simulator (Project 1-3)
 * Control player movement and animation
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TControlPlayer : MonoBehaviour
{
    public float speed;
    private float horizontalInput;
    private float forwardInput;
    private TutorialSceneManager gameRef;
    private Animator animator;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponentInChildren<Animator>();
        gameRef = GameObject.FindGameObjectWithTag("Goal").GetComponent<TutorialSceneManager>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        
            //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            //transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
            Vector3 movement = new Vector3(horizontalInput, 0.0f, forwardInput);

            //Moves in accordance to the direction the player is facing
            transform.rotation = Quaternion.LookRotation(movement);
            transform.Translate(movement * speed * Time.deltaTime, Space.World);

        //play walk while moving, idle while still
        if (horizontalInput == 0 && forwardInput == 0)
        {  
             rb.velocity = Vector3.zero;
            animator.SetFloat("running", 0);
        }
        else
            animator.SetFloat("running", 1);
        


    }
}
