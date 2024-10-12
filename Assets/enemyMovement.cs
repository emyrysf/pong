using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    [SerializeField] float enemySpeed = 1f;
    Vector3 direction;
    GameObject ball;
    
    void Update()
    {
        
        
        if (ball == null) {
            ball = GameObject.FindGameObjectWithTag("ball");
        }
        if(ball != null)
        {
            direction = new Vector3(0,ball.transform.position.y - transform.position.y,  0).normalized;
            transform.position += enemySpeed * Time.deltaTime * direction;
        }
        

    }
}
