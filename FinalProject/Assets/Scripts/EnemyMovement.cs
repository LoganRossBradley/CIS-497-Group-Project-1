using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 40;

    private bool gameOver = false;
    //private Rigidbody enemy;

    // Start is called before the first frame update
    void Start()
    {
        //enemy = GetComponent<Rigidbody>();
        StartCoroutine(Movement());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
    }

    IEnumerator Movement()
    {

        yield return new WaitForSeconds(3f);

        while (gameOver == false)
        {
            transform.Rotate(0, 180, 0);

            //enemy.AddForce(Vector3.forward * speed * Time.deltaTime, ForceMode.Impulse);


            yield return new WaitForSeconds(3f);
        }

    }
}