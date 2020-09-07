using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed = 300f;
    float movement = 0f;
    int hscore;

    //Update is called once per frame
    void Update()
    {
        /*movement = Input.GetAxisRaw("Horizontal");*/
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.position.x > 200)
            {
                movement = Input.touchCount;
            }
            else
            {
                movement = -Input.touchCount;
            }
        }
        else
        {
            movement = 0;
        }
    }
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        SceneManager.LoadScene("GameOver");
        hscore = PlayerPrefs.GetInt("HScore");
        PlayerPrefs.SetInt("CurrentScore", score.scoreCount);
        GetComponent<AudioSource>().Play();
        if (score.scoreCount >= hscore)
        {
            PlayerPrefs.SetInt("HScore", score.scoreCount);
        }
    }
}
