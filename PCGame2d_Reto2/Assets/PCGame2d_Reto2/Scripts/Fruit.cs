using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fruit : MonoBehaviour
{
    private Animator animator;
    private Score Score;
    public int point;

    //private Animator animator;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject scoreManagerObject = GameObject.Find("Panel");
        Score = scoreManagerObject.GetComponent<Score>();
        animator = GetComponentInChildren<Animator>();
        
        if (collision.CompareTag("Player"))
        {
            Debug.Log("eat apple");
            Score.addPoints(point);
            animator.SetTrigger("isEatTrigger");
            Destroy(gameObject, 0.9f);

        }
    }
}
