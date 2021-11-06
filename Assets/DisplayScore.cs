using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{

    public Text scoreText;
    public string scoreSufix = "pts";

    // Update is called once per frame
    void Update()
    {
        //update the score on the UI
        scoreText.text = Score.getScore() + scoreSufix;
    }
}
