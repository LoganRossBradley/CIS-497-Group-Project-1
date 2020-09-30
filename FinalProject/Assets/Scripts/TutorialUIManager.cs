using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TutorialUIManager : MonoBehaviour
{
    //references to UI management
    public GameObject movementInstruct;
    public GameObject movementPic;

    public GameObject enemyInstruct;
    public GameObject enemyPic;

    public GameObject objectiveInstruct;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name.Equals("SetWASD"))
        {
            movementInstruct.SetActive(true);
            movementPic.SetActive(true);

            enemyInstruct.SetActive(false);
            enemyPic.SetActive(false);
        }
        else if (collision.gameObject.name.Equals("SetEnemy01") || collision.gameObject.name.Equals("SetEnemy02"))
        {
            movementInstruct.SetActive(false);
            movementPic.SetActive(false);

            enemyInstruct.SetActive(true);
            enemyPic.SetActive(true);

            objectiveInstruct.SetActive(false);
        }
        else if(collision.gameObject.name.Equals("SetGoal"))
        {
            enemyInstruct.SetActive(false);
            enemyPic.SetActive(false);

            objectiveInstruct.SetActive(true);
        }
    }
}
