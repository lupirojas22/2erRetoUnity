using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trunk : MonoBehaviour
{
    private Animator animator;
    private Score Score;
    public int point;


    public void OnCollisionEnter2D(Collision2D collision)
    {

        GameObject scoreManagerObject = GameObject.Find("Panel");
        Score = scoreManagerObject.GetComponent<Score>();
        animator = GetComponentInChildren<Animator>();

        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("open trunk");
            Score.addPoints(point);
            animator.SetBool("isOpen", true);

        }
    }
}
