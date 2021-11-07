using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingTipsHandler : MonoBehaviour
{
    private string[] tips = { "Did you know ? : This loading screen doesn't do anything !",
        "Hint : SPAMMING SPACE IN THE WATERFALL LEVEL IS THE OPTIMUM STRATEGY",
        "Did you know ? : We first planned to make a third level, an Open-World, a character creation screen, and an option to skip this loading screen"};
    public Text tipsText;

    public void displayNewTip()
    {
        int tipIndex = Random.Range(0, tips.Length);
        tipsText.text = tips[tipIndex];
    }
}
