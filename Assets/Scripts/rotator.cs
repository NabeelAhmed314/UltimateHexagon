using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    AudioSource bgAudio;
    public bool audioPlay;
    // Start is called before the first frame update
    void Start()
    {

        PlayerPrefs.SetInt("CurrentScore", score.scoreCount);
        if (audioPlay)
        {
            bgAudio = GetComponent<AudioSource>();
            DontDestroyOnLoad(bgAudio);
        }

    }

}
