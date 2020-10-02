/*
 * James Difiglio, Benjamin Schuster
 * Project 1
 * Manages Player Control in tutorial 
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

    // Start is called before the first frame update
    void Start()
    {
        gameRef = GameObject.FindGameObjectWithTag("Goal").GetComponent<TutorialSceneManager>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        if (gameRef.startTutorial)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        }


    }
}
