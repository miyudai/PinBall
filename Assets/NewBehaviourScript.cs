using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    private GameObject scoreText;
    private int score = 0;
   

    void Start()
    {
        score = 0;

        this.scoreText = GameObject.Find("SetScore");

        SetScore();


    }



    void OnCollisionEnter(Collision collision)
    {
        string yourTag = collision.gameObject.tag;

        if (yourTag == "LargeStarTag")
        {
            score += 20;
        }
        else if (yourTag == "SmallStarTag")
        {
            score += 10;
        }

        else if (yourTag == "LargeCloudTag")
        {
            score += 30;
        }

        else if (yourTag == "SmallCloudTag")
        {
            score += 15;
        }
        SetScore();

    }

    void SetScore()
    {
        this.scoreText.GetComponent<Text>().text ="得点" + score.ToString();
    }
}    
