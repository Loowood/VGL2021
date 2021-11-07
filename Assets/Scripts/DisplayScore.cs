using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{

    public Text scoreText;
    public string scoreSufix = "pts";
    public int objectif = 15;

    private void Start()
    {
        Score.razScore();
    }

    // Update is called once per frame
    void Update()
    {
        //update the score on the UI
        scoreText.text = Score.getScore() + " / " + objectif + scoreSufix;
    }
}
