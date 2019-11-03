using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{

    public Text text;

    int player1Score;
    int player2Score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player1Score = GameObject.Find("BlueArea").GetComponent<WinState>().score;
        player2Score = GameObject.Find("RedArea").GetComponent<WinState>().score;

        if (player1Score >= 300)
        {
            text.text = "Blue wins";
        }
        if(player2Score >= 300)
        {
            text.text = "Red wins";
        }
    }
}
