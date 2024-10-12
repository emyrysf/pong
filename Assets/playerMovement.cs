using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    [SerializeField] float playerSpeed = 1f;
    [SerializeField] float rotationSpeed = 1f;
    [SerializeField] GameObject Ball;
    Vector3 rotationVector;

    private void Start()
    {
        rotationVector = new Vector3(0, 0,(int) rotationSpeed * Time.deltaTime);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            transform.position += new Vector3(0, playerSpeed * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.S)) {
            transform.position += new Vector3(0, -playerSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles += rotationVector;
            if(transform.eulerAngles.z > 15 && transform.eulerAngles.z < 345)
                transform.eulerAngles -= rotationVector;

        }



        else if (Input.GetKey(KeyCode.D)) { 
            transform.eulerAngles -= rotationVector;
            if (transform.eulerAngles.z > 15 && transform.eulerAngles.z < 345)
                transform.eulerAngles += rotationVector;
        }

        if(Input.GetKeyDown(KeyCode.R)) {
            //recreate ball
            Destroy(GameObject.FindGameObjectWithTag("ball"));
            Instantiate(Ball);
        }

        if(Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (!Screen.fullScreen)
            {
                Screen.fullScreen = !Screen.fullScreen;
            }
        }
    }

}
