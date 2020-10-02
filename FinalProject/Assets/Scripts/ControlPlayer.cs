/*
 * James Difiglio, Benjamin Schuster
 * Project 1
 * Manages Player Control in main game 
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

    // Start is called before the first frame update
    void Start()
    {
        gameRef = GameObject.FindGameObjectWithTag("Goal").GetComponent<GoalManager>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        if(!gameRef.gameOver)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        }
        
    }

    
}
