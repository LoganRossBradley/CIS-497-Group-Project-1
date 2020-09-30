using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    public bool gameOver = false;
    public bool win = false;

    public GameObject winText;
    public GameObject loseText;

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
        }
        else if (gameOver && !win)
        {
            loseText.SetActive(true);
        }

        //this spot can be for scene reset
    }

    private void OnTriggerEnter(Collider other)
    {
        win = true;
        gameOver = true;
    }
}
