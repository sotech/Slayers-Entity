using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayMusic : MonoBehaviour
{
    private AudioSource bgm;
    private bool volumeReached;

    private void Start()
    {
        bgm = GetComponent<AudioSource>();
        bgm.volume = 0;
        bgm.Play();
        //Play and gradually increase its volume
        StartCoroutine(PlayBackgroundMusic());
    }

    IEnumerator PlayBackgroundMusic()
    {
        while (!volumeReached)
        {
            bgm.volume = bgm.volume + Mathf.Lerp(0f, 1f, Time.time);
            if(bgm.volume == 1f)
            {
                volumeReached = true;
            }
            yield return new WaitForSeconds(0.5f);
        }
    }





}
