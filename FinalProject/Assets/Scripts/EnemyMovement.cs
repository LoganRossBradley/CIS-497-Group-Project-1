﻿/*
 * James Difiglio
 * Project 1
 * Manages Enemy Control in main game 
 */
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 40;

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
        if (!goalRef.gameOver)
        {
            animator.SetFloat("Speed_f", 1f);
            transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
        }
        else
            animator.SetFloat("Speed_f", 0f);
    }

    IEnumerator Movement()
    {

        yield return new WaitForSeconds(4f);

        while (!goalRef.gameOver)
        {
            transform.Rotate(0, 180, 0);

            //enemy.AddForce(Vector3.forward * speed * Time.deltaTime, ForceMode.Impulse);


            yield return new WaitForSeconds(4f);
        }

    }
}