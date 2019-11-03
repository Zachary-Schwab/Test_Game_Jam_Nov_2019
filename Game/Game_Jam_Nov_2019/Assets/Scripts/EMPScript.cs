using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EMPScript : MonoBehaviour
{
    GameObject player1;
    GameObject player2;

    public float cooldown;
    float currentCooldown;

    public float empStunTime;

    // Start is called before the first frame update
    void Start()
    {
        currentCooldown = cooldown;
        player1 = GameObject.Find("Tank_Gun");
        player2 = GameObject.Find("TankHeadTextured");
    }

    // Update is called once per frame
    void Update()
    {
        countdown();
    }

    void countdown()
    {
        cooldown -= Time.deltaTime;

        if (cooldown <= 0f)
        {
            Destroy(gameObject);

            cooldown = currentCooldown;
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (col.gameObject.name == "Tank")
            {
                player2.GetComponent<AimingScript>().EMP(empStunTime);
            }
            else if (col.gameObject.name == "Tank2")
            {
                player1.GetComponent<AimingScript>().EMP(empStunTime);
            }

            Destroy(gameObject);
        }
    }
}
