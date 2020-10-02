/*
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

    // Start is called before the first frame update
    void Start()
    {
        goalRef = GameObject.FindGameObjectWithTag("Goal").GetComponent<GoalManager>();
        //enemy = GetComponent<Rigidbody>();
        StartCoroutine(Movement());
    }

    // Update is called once per frame
    void Update()
    {
        if(!goalRef.gameOver)
            transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
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