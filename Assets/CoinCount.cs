using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCount : MonoBehaviour
{
    const string coinTag = "Coin";
    public float destroyCoinDelay = 2f;

    private void OnTriggerEnter(Collider target)
    {
        //detect a coin
        if (target.tag == coinTag)
        {
            
            //add 1 point to the score
            Score.addScore(1);

            Debug.Log("Score = " + Score.getScore());

            //destroy the coin with a delay
            Destroy(target.gameObject, destroyCoinDelay);
        }
    }
}
