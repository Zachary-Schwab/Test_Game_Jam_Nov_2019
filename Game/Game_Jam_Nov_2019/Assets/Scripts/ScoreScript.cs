using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public Text player1Text;
    public Text player2Text;

    int player1Score;
    int player2Score;

    // Start is called before the first frame update
    void Start()
    {
        //Grab the total balls on each side of the field  
        updateScore();
    }

  public void updateScore()
    {
        player1Score = GameObject.Find("Goal (1)").GetComponent<Ball_Goal_Collide>().score;
        player2Score = GameObject.Find("Goal (2)").GetComponent<Ball_Goal_Collide>().score;

        player1Text.text = player1Score.ToString();
        player2Text.text = player2Score.ToString();
    }
}
