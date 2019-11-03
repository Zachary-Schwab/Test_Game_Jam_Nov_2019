using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AmmoTextScript : MonoBehaviour
{
    public TextMeshProUGUI ones;
    public TextMeshProUGUI tens;

    public AmmoScript ammoScript;

    void Update()
    {
        updateAmmoCount();
    }

    public void updateAmmoCount()
    {
        if (ammoScript.ammoCount >= 10)
        {
            tens.text = (ammoScript.ammoCount / 10).ToString();
            ones.text = (ammoScript.ammoCount % 10).ToString();
        }
        else
        {
            tens.text = "0";
            ones.text = ammoScript.ammoCount.ToString();
        }
    }
}
