/*
 * Benjamin Schuster
 * Project 1
 * Manages win/loss conditions and texts. Also restarts games
 */
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    public bool gameOver = false;
    public bool win = false;
    public bool gotCorona = false;

    public GameObject winText;
    public GameObject loseTextTime;
    public GameObject loseTextIll;
    public GameObject goalText;
    public GameObject timerText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver && win)
        {
            winText.SetActive(true);
            timerText.SetActive(false);
            goalText.SetActive(false);
        }
        else if (gameOver && !win && gotCorona)
        {
            loseTextIll.SetActive(true);
            timerText.SetActive(false);
            goalText.SetActive(false);
        }
        else if (gameOver && !win && !gotCorona)
        {
            loseTextTime.SetActive(true);
            timerText.SetActive(false);
            goalText.SetActive(false);
        }

        //this spot can be for scene reset
    }

    private void OnTriggerEnter(Collider other)
    {
        win = true;
        gameOver = true;
    }
}
