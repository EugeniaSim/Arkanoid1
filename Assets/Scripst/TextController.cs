using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text scoreText;
    public float score = 0;
    

    public void UpdateScore(int step)
    {
        score += step;
        scoreText.text = "Score: " + score; 
    }
}
