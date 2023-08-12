using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Lives : MonoBehaviour
{
    private TMP_Text textLives;
    private int currentLives;
    public GameObject charterMoviGameObject;


    public void StarLives(int liveStar)
    {
        textLives = GameObject.Find("Lives").GetComponent<TMP_Text>();
        textLives.text = liveStar.ToString(); // Aqu� debes actualizar el campo 'text' del objeto Text
        currentLives = liveStar;
    }

    public void DecrementLives(int point)
    {
        CharterMovi charterMoviScript = charterMoviGameObject.GetComponent<CharterMovi>();
       
        if (currentLives > 0)
        {
            currentLives -= point;
            textLives.text = currentLives.ToString();
        } 
        else if (currentLives <= 0)
        {
            // Aqu� puedes llamar a un m�todo que maneje la l�gica del Game Over
            // Por ejemplo: GameOver();
            Debug.Log("Player Dead");
            charterMoviScript.GameOver();
        }

    }

 


}
