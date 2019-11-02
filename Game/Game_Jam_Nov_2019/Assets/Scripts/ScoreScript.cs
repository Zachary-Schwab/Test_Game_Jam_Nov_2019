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
    void Awake()
    {
        //Grab the total balls on each side of the field  
        updateScore();
    }

    void Update()
    {
        updateScore();
    }

  public void updateScore()
    {
        player1Score = GameObject.Find("BlueArea").GetComponent<WinState>().score;
        player2Score = GameObject.Find("RedArea").GetComponent<WinState>().score;

        player1Text.text = player1Score.ToString();
        player2Text.text = player2Score.ToString();
    }
}
