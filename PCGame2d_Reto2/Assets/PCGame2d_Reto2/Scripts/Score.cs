using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    private TMP_Text totalScore;
    public int TotalPoints;

    public void addPoints(int point)
    {
        totalScore = GameObject.Find("TotalScore").GetComponent<TMP_Text>();
        TotalPoints += point;
        totalScore.text = TotalPoints.ToString(); // Aquí debes actualizar el campo 'text' del objeto Text
    }
}