/*
 * Benjamin Schuster
 * Project 1
 * Title and scene transition for tutorial
 * */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialSceneManager : MonoBehaviour
{
    public bool startTutorial = false;
    public GameObject controlTxt;
    public GameObject controlPic;
    public GameObject tutBanner;
    public GameObject titleCard;
    public GameObject bootScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!startTutorial && Input.GetKey(KeyCode.R))
        {
            startTutorial = true;
            titleCard.SetActive(false);
            bootScreen.SetActive(false);
            controlTxt.SetActive(true);
            controlPic.SetActive(true);
            tutBanner.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("ProjectScene 1");
    }
}
