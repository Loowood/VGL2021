using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingTipsHandler : MonoBehaviour
{
    private string[] tips = { "Did you know ? : This loading screen doesn't do anything !",
        "Hint : SPAMMING SPACE IN THE WATERFALL LEVEL IS THE OPTIMUM STRATEGY",
        "Did you know ? : We first planned to make a third level, an Open-World, a character creation screen, and an option to skip this loading screen",
        "True Tip : Did you notice ? The coins will spawn under the red arrow",
        "Don't pay much attention to the objective, the rewards aren't worth it",
        "You can not die in this game ! But if you succeed, you die in real life, so beware",
        "You will never guess what the reward is at 1000 points ! ... we neither",
        "We are randomly chosing a coin sound from 20 sounds, and we always chose the same one",
        "We originally wanted the game to be called INSERT A COIN, but there was already too many contenders in the jam",
        "I swear this screen will be the majority of your playtime",
        "Did you know ? The arcade's lines are not straight. Now you can't unsee it"};
    public Text tipsText;

    public void displayNewTip()
    {
        int tipIndex = Random.Range(0, tips.Length);
        tipsText.text = tips[tipIndex];
    }
}
