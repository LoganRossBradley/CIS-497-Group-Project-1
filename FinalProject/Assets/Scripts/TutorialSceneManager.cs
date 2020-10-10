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
    public GameObject textTip;
    private bool tutorialOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(tutorialOver && Input.GetKey(KeyCode.R))
        {
            resetScene();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        textTip.SetActive(true);
        tutorialOver = true;
    }

    public void resetScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
