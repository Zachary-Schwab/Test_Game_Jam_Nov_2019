﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Goal_Collide : MonoBehaviour
{
    public int score;

    ScoreScript scoreScript1;
    ScoreScript scoreScript2;
    // Start is called before the first frame update
    void Start()
    {
        scoreScript1 = GameObject.Find("Score_Canvas_1").GetComponent<ScoreScript>();   
        scoreScript2 = GameObject.Find("Score_Canvas_2").GetComponent<ScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Shootable")
        {
            this.gameObject.transform.parent.gameObject.GetComponent<AudioSource>().Play();
            //Destroy(collision.gameObject);
            score++;
            scoreScript1.updateScore();
            scoreScript2.updateScore();
            this.gameObject.transform.parent.gameObject.GetComponent<DropBalls>().DropBall();
            this.gameObject.transform.parent.gameObject.GetComponent<GoalMovement>().CheckState(score);
        }
    }
}