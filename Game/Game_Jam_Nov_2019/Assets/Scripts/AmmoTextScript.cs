using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoTextScript : MonoBehaviour
{

    public Text ones;
    public Text tens;

    public AmmoScript ammoScript;

    // Start is called before the first frame update
    void Start()
    {
        //ammoScript = GameObject.Find("Tank_Gun").GetComponent<AmmoScript>();
        updateAmmoCount();
    }

   public void updateAmmoCount()
    {
        if (ammoScript.ammoCount >= 10)
        {
            tens.text = "1";
            ones.text = "0";
        }
        else
        {
            tens.text = "0";
            ones.text = ammoScript.ammoCount.ToString();
        }
    }
}
