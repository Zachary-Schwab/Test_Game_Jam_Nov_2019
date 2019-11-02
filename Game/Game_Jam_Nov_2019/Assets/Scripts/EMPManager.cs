using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EMPManager : MonoBehaviour
{
    public float spawningCooldown;
    float currentCooldown;
    GameObject[] positions;

    // Start is called before the first frame update
    void Start()
    {
        //Add all spawning positions into the array
        currentCooldown = spawningCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        countdown();
    }

    void countdown()
    {
        currentCooldown -= Time.deltaTime;

        if(currentCooldown <= 0f)
        {
            spawnEMP();
            currentCooldown = spawningCooldown;
        }

    }

    void spawnEMP()
    {
        //Gen random position
        //EMP = Instantiate(Gameobject, rand_position, rotation)
        //EMP will update its own cooldown
    }

}
