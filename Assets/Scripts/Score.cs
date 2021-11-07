using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]
    static int score = 0;

    public static void addScore(int pointsToAdd)
    {
        score += pointsToAdd;
    }

    public static int getScore()
    {
        return score;
    }

    public static void razScore()
    {
        score = 0;
    }
}
