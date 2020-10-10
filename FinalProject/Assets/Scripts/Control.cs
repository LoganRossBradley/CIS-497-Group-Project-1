/*
 * Benjamin Schuster
 * Social Distancing Sim (Project 1-3)
 * Loads next scene when NextScene() is triggered. Used for button based scene transition
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Control : MonoBehaviour
{
    public string targetScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(targetScene);
    }
}
