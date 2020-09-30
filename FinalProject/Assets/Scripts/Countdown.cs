/*
 * Benjamin Schuster
 * Project 1
 * Countdown timer for the game, update UI timer
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Countdown : MonoBehaviour
{
    public float timeLeft;
    public Text timerRef;
    //this can be changed to a reference once we have a proper system controller
    private GoalManager goalRef;

    // Start is called before the first frame update
    void Start()
    {
        goalRef = GameObject.FindGameObjectWithTag("Goal").GetComponent<GoalManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //Either countdown or set gamestate to gameover if out of time
        if(timeLeft > 0 && !goalRef.gameOver)
        {
            timeLeft -= Time.deltaTime;
            timerRef.text = "Reach the goal in time!\n Time Remaining: " + timeLeft.ToString("F0");
        }
        else if(timeLeft <= 0 && !goalRef.gameOver)
        {
            Debug.Log("Out of Time! Game Over!");
            goalRef.gameOver = true;
        }
    }

    //Powerups can call this so time can be added 
    void addTime()
    {
        timeLeft += 10.0f;
    }
}
