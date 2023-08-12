using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{

    private CharterMovi CharterMovi;

    //private Animator animator;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            Debug.Log("you are  die");
            CharterMovi = collision.gameObject.GetComponent<CharterMovi>();

            if (CharterMovi != null)
            {
                CharterMovi.GameOver();
            }
        }
    }
}
