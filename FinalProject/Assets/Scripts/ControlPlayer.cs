/*
 * Benjamin Schuster, James Difiglio, Jerod Lockhart
 * Project 1
 * Control player movement and animation
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    public float speed;
    private float horizontalInput;
    private float forwardInput;
    private GoalManager gameRef;
    public Animator animator;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponentInChildren<Animator>();
        gameRef = GameObject.FindGameObjectWithTag("Goal").GetComponent<GoalManager>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        if (!gameRef.gameOver)
        {
            // transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            // transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
            Vector3 movement = new Vector3(horizontalInput, 0.0f, forwardInput);

            //Moves in accordance to the direction the player is facing
            transform.rotation = Quaternion.LookRotation(movement);
            transform.Translate(movement * speed * Time.deltaTime, Space.World);

            if (horizontalInput == 0 && forwardInput == 0)
            {
                //this sets velocity to 0, fixes phantom movement
                rb.velocity = Vector3.zero;
                animator.SetFloat("running", 0);
            }
            else
                animator.SetFloat("running", 1);


        }

    }


}
