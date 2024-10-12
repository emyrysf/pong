using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    [SerializeField] float ballSpeed = 400f;
    Rigidbody2D rb;
    AudioSource src;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        rb.velocity = randDirec() * ballSpeed;

        src = GetComponent<AudioSource>();

    }

    
    Vector3 randDirec()
    {
        Vector3 direction = new Vector3(Random.Range(-1f,1f), Random.Range(-0.3f,0.3f));
        while (direction.x == 0 || direction.y == 0)
        {
            direction = new Vector3(Random.Range(-1f, 1.01f), Random.Range(-0.3f, 0.3f));
        }
        direction.Normalize();
        return direction;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        src.Play();
    }

}
