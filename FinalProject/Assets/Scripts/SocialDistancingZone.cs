using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialDistancingZone : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset = new Vector3(0, 0, 0);


    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }

}