using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
  
    private Animator animator;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        animator = GetComponentInChildren<Animator>();

        if (collision.transform.CompareTag("Player") && (CharterMovi.keyTouchBox) )
        {
               animator.SetTrigger("isDestroy");
               Destroy(gameObject, 0.20f);  
        }     
    }

}
