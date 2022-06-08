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
        this.gamepointText=GameObject.Find("GamePoint");
        score=0;
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gamepointText.GetComponent<Text>().text=score.ToString();
    }

    void OnCollisionEnter( Collision other )

    {
        if (other.gameObject.tag=="SmallStarTag")
        {
            this.score+=10;
        }
        else if(other.gameObject.tag=="LargeStarTag")
        {
            this.score+=20;
        }
        else if(other.gameObject.tag=="SmallCloudTag")
        {
            this.score+=30;
        }
        else if(other.gameObject.tag=="LargeCloudTag")
        {
            this.score+=50;
        }
    }
}
