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
    private float timeStart;

    public Text timerRef;
    public GameObject goalText;
    public GameObject meltText;

    private GoalManager goalRef;

    // Start is called before the first frame update
    void Start()
    {
        timeStart = timeLeft;
        goalRef = GameObject.FindGameObjectWithTag("Goal").GetComponent<GoalManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //Either countdown or set gamestate to gameover if out of time
        if(timeLeft > 0 && !goalRef.gameOver)
        {
            timeLeft -= Time.deltaTime;
            timerRef.text = timeLeft.ToString("F0");

            //color timer red when low on time
            if(timeLeft <= 10)
            {
                timerRef.color = Color.red;
            }

            //remove the starting text after a few seconds
            if(timeLeft < timeStart - 6)
            {
                goalText.SetActive(false);
                meltText.SetActive(false);
            }

        }
        else if(timeLeft <= 0 && !goalRef.gameOver)
        {
            //Debug.Log("Out of Time! Game Over!");
            goalRef.gameOver = true;
        }
    }

    //Powerups can call this so time can be added 
    void addTime()
    {
        timeLeft += 10.0f;
    }
}
