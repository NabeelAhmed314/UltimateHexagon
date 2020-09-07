using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scoreShow : MonoBehaviour
{
    public Text ScoreText;
    public Text Hscore;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = PlayerPrefs.GetInt("CurrentScore").ToString();
        Hscore.text = PlayerPrefs.GetInt("HScore").ToString();
    }

}
