using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Score
{

    static int score = 0;

    public static void addScore(int pointsToAdd)
    {
        score += pointsToAdd;
    }

    public static int getScore()
    {
        return score;
    }
}
