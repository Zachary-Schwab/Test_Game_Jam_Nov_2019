using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoScript : MonoBehaviour
{
    public int ammoCount;
    public int maxAmmo;

    // Start is called before the first frame update
    void Start()
    {
        ammoCount = 0;
    }

    public bool addAmmo()
    {
        if(ammoCount < maxAmmo)
        {
            ammoCount++;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool removeAmmo()
    {
        if(ammoCount > 0)
        {
            ammoCount--;
            return true;
        }
        else
        {
            return false;
        }
    }

}
