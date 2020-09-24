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
    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Either countdown or set gamestate to gameover if out of time
        if(timeLeft > 0 && !gameOver)
        {
            timeLeft -= Time.deltaTime;
            timerRef.text = "Time Remaining:\n" + timeLeft.ToString("F0");
        }
        else if(timeLeft <= 0 && !gameOver)
        {
            Debug.Log("Out of Time! Game Over!");
            gameOver = true;
        }
    }

    //Powerups can call this so time can be added 
    void addTime()
    {
        timeLeft += 10.0f;
    }
}
