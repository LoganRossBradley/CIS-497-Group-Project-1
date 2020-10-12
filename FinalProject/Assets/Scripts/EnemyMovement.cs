/*
 * James Difiglio, Logan Ross
 * Social Distancing Simulator (Project 1-3)
 * Manages Enemy Control in main game 
 * logan - allows us to edit speed and time before they turn around for each enemy
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 40;
    public float turnTimer = 4f;

    //private Rigidbody enemy;
    private GoalManager goalRef;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        goalRef = GameObject.FindGameObjectWithTag("Goal").GetComponent<GoalManager>();
        //enemy = GetComponent<Rigidbody>();
        StartCoroutine(Movement());
    }

    // Update is called once per frame
    void Update()
    {
        if (!goalRef.gameOver && speed != 0)
        {
            animator.SetFloat("running", 1f);
            transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
        }
        else
            animator.SetFloat("running", 0f);
    }

    IEnumerator Movement()
    {

        yield return new WaitForSeconds(turnTimer);

        while (!goalRef.gameOver)
        {
            transform.Rotate(0, 180, 0);

            //enemy.AddForce(Vector3.forward * speed * Time.deltaTime, ForceMode.Impulse);


            yield return new WaitForSeconds(turnTimer);
        }

    }
}