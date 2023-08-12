using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
   
    private Score Score;
    public int point;

    //private Animator animator;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject scoreManagerObject = GameObject.Find("Panel");
        Score = scoreManagerObject.GetComponent<Score>();

        if (collision.CompareTag("Player"))
        {
            Debug.Log("coin");
            Score.addPoints(point);
            Destroy(gameObject, 0.9f);

        }
    }
}


