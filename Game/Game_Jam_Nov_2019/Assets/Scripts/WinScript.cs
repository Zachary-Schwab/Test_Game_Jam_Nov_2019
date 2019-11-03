using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{
    public int scoreToWin;

    public Text text;

    int player1Score;
    int player2Score;

    CanvasGroup canvasGroup;

    // Start is called before the first frame update
    void Start()
    {
        canvasGroup = this.GetComponent<CanvasGroup>();

        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        player1Score = GameObject.Find("BlueArea").GetComponent<WinState>().score;
        player2Score = GameObject.Find("RedArea").GetComponent<WinState>().score;

        if (player1Score >= scoreToWin)
        {
            text.text = "Blue wins";
            display();
        }
        if (player2Score >= scoreToWin)
        {
            text.text = "Red wins";
            display();
        }
    }

    void display()
    {
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
    }
}
