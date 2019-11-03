using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoScript : MonoBehaviour
{
    public int ammoCount;
    public int maxAmmo;


    public AmmoTextScript ammoText;
    // Start is called before the first frame update
    void Start()
    {
        ammoCount = 0;
       // ammoText = GameObject.Find("Ammo_Canvas").GetComponent<AmmoTextScript>();
    }

    public bool addAmmo(int ammo = 1)
    {
        bool boolean;

        if(ammoCount < maxAmmo)
        {
            ammoCount+= ammo;
            boolean = true;
        }
        else
        {
            boolean = false;
        }
        ammoText.updateAmmoCount();

        return boolean;
    }

    public bool removeAmmo()
    {
        bool boolean;

        if (ammoCount > 0)
        {
            ammoCount--;
            boolean = true;
        }
        else
        {
            boolean = false;
        }
        ammoText.updateAmmoCount();
        return boolean;
    }
}
