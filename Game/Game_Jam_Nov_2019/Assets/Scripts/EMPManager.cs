using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EMPManager : MonoBehaviour
{
    public float spawningCooldown;
    float currentCooldown;
    public GameObject[] positionsP1;
    public GameObject[] positionsP2;
    public GameObject EMP;

    public GameObject[] EMPList;
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

        if(EMPList[0] == null || EMPList[1] == null)
        {
            Destroy(EMPList[0]);
            Destroy(EMPList[1]);
        }
    }

    void countdown()
    {
        currentCooldown -= Time.deltaTime;

        if (currentCooldown <= 0f)
        {
            spawnEMP();
            currentCooldown = spawningCooldown;
        }

    }

    void spawnEMP()
    {
        int pos1 = Random.Range(0, positionsP1.Length);
        int pos2 = Random.Range(0, positionsP2.Length);

        EMPList[0] = (Instantiate(EMP, positionsP1[pos1].transform.position, transform.rotation));
        EMPList[1] = (Instantiate(EMP, positionsP2[pos2].transform.position, transform.rotation));
    }

}
