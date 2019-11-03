using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonScript : MonoBehaviour
{


    public void swapToHelp()
    {
        SceneManager.LoadScene("How_To_Play");
    }

    public void swapToGame()
    {
        SceneManager.LoadScene("First_Single_Player_Test");
    }

}
