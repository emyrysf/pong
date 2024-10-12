using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twoPlayerMovement : MonoBehaviour
{   
    [SerializeField] float rotationSpeed = 1f;
    [SerializeField] float enemySpeed = 1f;
    Vector3 rotationVector;

    private void Start()
    {
        rotationVector = new Vector3(0, 0, (int)rotationSpeed * Time.deltaTime);
    }
    

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, enemySpeed * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -enemySpeed * Time.deltaTime, 0);
        }
        

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.eulerAngles += rotationVector;
            if (transform.eulerAngles.z > 15 && transform.eulerAngles.z < 345)
                transform.eulerAngles -= rotationVector;

        }



        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.eulerAngles -= rotationVector;
            if (transform.eulerAngles.z > 15 && transform.eulerAngles.z < 345)
                transform.eulerAngles += rotationVector;
        }
    }
}
