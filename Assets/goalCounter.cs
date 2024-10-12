using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class goalCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ScoreBoard;
    [SerializeField] GameObject Ball;
    int count = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        count++;
        ScoreBoard.text = count.ToString(); 
        Destroy(collision.gameObject);
        Instantiate(Ball);
    }

}
