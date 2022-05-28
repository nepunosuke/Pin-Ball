using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinBallScore : MonoBehaviour
{
    private GameObject gamepointText;
    private int score=0;



    // Start is called before the first frame update
    void Start()
    {
        score=0;
        this.gamepointText=GameObject.Find("GamePointText");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter( Collision other )

    {
        if (tag=="SmallStarTag")
        {
            score+=10;
        }
        else if(tag=="LargeStarTag")
        {
            score+=20;
        }
        else if(tag=="SmallCloudTag")
        {
            score+=30;
        }
        else if(tag=="LargeCloudTag")
        {
            score+=50;
        }
    }
}
