﻿/*
 * James Difiglio
 * Social Distancing Simulator (Project 1-3)
 * Makes camera follow player
 * */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset = new Vector3(0, 20, 0);


    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }

}

