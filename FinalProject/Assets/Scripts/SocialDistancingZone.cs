using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialDistancingZone : MonoBehaviour
{

    public bool gameOver = false;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Game Over");
        gameOver = true;
    }

}