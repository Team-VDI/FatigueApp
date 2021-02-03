using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour 
{
    public int scoreValue;
    public TMP_Text score;

    public void CorrectAnswer()
    {
        scoreValue = scoreValue + 1;
        score.text = "" + scoreValue;
    }
}

