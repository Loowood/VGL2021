using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCount : MonoBehaviour
{
    const string coinTag = "Coin";
    public float destroyCoinDelay = 2f;
    public List<AudioClip> audioClipsForCoinsPickUp;

    private void OnTriggerEnter(Collider target)
    {
        //detect a coin
        if (target.tag == coinTag)
        {
            
            //add 1 point to the score
            Score.addScore(1);

            AudioSource.PlayClipAtPoint(getClipToplay(), target.transform.position, 0.5f);

            //destroy the coin with a delay
            Destroy(target.gameObject, destroyCoinDelay);
        }
    }

    private AudioClip getClipToplay()
    {
        int clipIndex = Random.Range(0, audioClipsForCoinsPickUp.Count);
        return audioClipsForCoinsPickUp[clipIndex];
    }
}
