/*
 * James Difiglio, Benjamin Schuster
 * Project 1
 * Manages Enemy Control in tutorial 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TEnemyMovement : MonoBehaviour
{
    public float speed = 40;

    private bool gameOver = false;
    //private Rigidbody enemy;
    //private GoalManager goalRef;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //goalRef = GameObject.FindGameObjectWithTag("Goal").GetComponent<GoalManager>();
        //enemy = GetComponent<Rigidbody>();
        animator = GetComponentInChildren<Animator>();
        StartCoroutine(Movement());
    }

    // Update is called once per frame
    void Update()
    {
        //if (!goalRef.gameOver)
            transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
        animator.SetFloat("Speed_f", 1f);
    }

    IEnumerator Movement()
    {

        yield return new WaitForSeconds(4f);

        while (!gameOver)
        {
            transform.Rotate(0, 180, 0);

            //enemy.AddForce(Vector3.forward * speed * Time.deltaTime, ForceMode.Impulse);


            yield return new WaitForSeconds(4f);
        }

    }
}
