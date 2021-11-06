using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSounds : MonoBehaviour
{

    const string coinTag = "Coin";
    public List<AudioClip> audioClipsForCoinsCollide;
    public static int counter = 0;
    public float soundCooldown = 0.25f;
    public int maxSameSound = 5;
    private void OnCollisionEnter(Collision target)
    {
        //detect a coin
        if (target.gameObject.tag == coinTag)
        {
            if (counter < 5)
            {
                counter++;
                AudioSource.PlayClipAtPoint(getClipToplay(), target.transform.position, 0.5f);
                Invoke(nameof(freeSoundUsage), soundCooldown);
            }
        }
    }

    private AudioClip getClipToplay()
    {
        int clipIndex = Random.Range(0, audioClipsForCoinsCollide.Count);
        return audioClipsForCoinsCollide[clipIndex];
    }

    private void freeSoundUsage()
    {
        counter--;
    }
}
