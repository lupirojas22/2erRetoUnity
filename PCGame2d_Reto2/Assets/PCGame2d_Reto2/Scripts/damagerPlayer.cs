using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damagerPlayer : MonoBehaviour
{
    public CharterMovi CharterMovi;
    private Lives Lives;

    public int point;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject LivesManagerObject = GameObject.Find("Panel");
        Lives = LivesManagerObject.GetComponent<Lives>();
        

        if (collision.transform.CompareTag("Player"))
        {
      
            Lives.DecrementLives(point);// quitamos vida

            if (CharterMovi != null)
            {
                Debug.Log("damage play");
                CharterMovi.painPlayer();
            }

           
       }
    }
}
