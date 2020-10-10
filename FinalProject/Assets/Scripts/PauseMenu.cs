/*
 * Benjamin Schuster
 * Social Distancing Simulator (Project 1-3)
 * Opens/Closes pause menu
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject menu;
    public bool menuOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //pause 
        if(Input.GetKeyDown(KeyCode.Escape) && !menuOpen)
        {
            menuOpen = true;
            menu.SetActive(true);
            Time.timeScale = 0;
        }
        //unpause
        else if (Input.GetKeyDown(KeyCode.Escape) && menuOpen)
        {
            closeMenu();
        }

    }

    public void closeMenu()
    {
        menuOpen = false;
        menu.SetActive(false);
        Time.timeScale = 1;
    }
}
