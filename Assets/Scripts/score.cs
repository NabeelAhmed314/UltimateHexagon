using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class score : MonoBehaviour
{
    public Text ScoreText;
    public Text Hscore;
    public static int scoreCount ;
    public static bool bonusSound = false;
    // Start is called before the first frame update
    void Start()
    {
        scoreCount = 0;
        ScoreText.text = (scoreCount).ToString();
        Hscore.text = PlayerPrefs.GetInt("HScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = scoreCount.ToString();
        Hscore.text = PlayerPrefs.GetInt("HScore").ToString();
        if (bonusSound)
        {
            GetComponent<AudioSource>().Play();
            bonusSound = false;
        }
    }

}
