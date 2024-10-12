using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuScript : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject Ball;
    
    // Start is called before the first frame update
    public void PlayOne()
    {
            enemy.GetComponent<enemyMovement>().enabled = true;
            enemy.GetComponent<twoPlayerMovement>().enabled = false;
            Instantiate(Ball);
    }

    public void PlayTwo()
    {
            enemy.GetComponent<enemyMovement>().enabled = false;
            enemy.GetComponent<twoPlayerMovement>().enabled = true;
            Instantiate(Ball);
    }


}
