using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class testcollect2 : MonoBehaviour {

    public Text scoretext;

    int score = 0;

    private void Start()
    {
        scoretext.text = "score = " + score.ToString();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Collide")
        {
            score++;



            if (score == 2)
            {
                SceneManager.LoadScene("LEVEL 2");
            }
            else
            {
                scoretext.text = "score = " + score.ToString();
            }


            Debug.Log(score);
        }
    }

}
