using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VacuumScript : MonoBehaviour
{

    public bool canSuck = false;
    public float cooldown;
    public int ammo = 0;
   public float currentCooldown;

    public KeyCode suckKey;
    public AmmoScript ammoScript;

    // Start is called before the first frame update
    void Start()
    {
        currentCooldown = cooldown;
       // ammoScript = GameObject.Find("Tank_Gun").GetComponent<AmmoScript>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    void CheckInput()
    {
        if (Input.GetKeyDown(suckKey))
        {
            canSuck = true;
        }

        if (Input.GetKeyUp(suckKey))
        {
            canSuck = false;
        }

    }


    private void OnTriggerStay(Collider collider)
    {
        if (canSuck && collider.gameObject.tag == "ball")
        {
            currentCooldown -= Time.deltaTime;

            if (currentCooldown <= 0f)
            {
                if (ammoScript.addAmmo())
                {
                    Destroy(collider.gameObject);
                    resetValues();
                }
            }
        }
    }

    void resetValues()
    {
        currentCooldown = cooldown;
    }
}
