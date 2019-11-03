using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenBallTargetOnOff : MonoBehaviour
{
    public GameObject []targets;
    public float currentTimer = 0;
    public float respawnTimer;
    public float timerReduction;
    public float timeAlive;
    public float currentTimeAlive = -15;
    public float timerAliveReduction;
    GameObject currentAlive;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject target in targets)
        {
            foreach (Transform child in target.transform)
            {
                if (child.name != "ring")
                    child.GetComponent<MeshRenderer>().enabled = false;
                else if (child.name == "ring")
                {
                    child.GetComponent<MeshCollider>().enabled = false;
                }
            }
        }
        currentTimeAlive = -respawnTimer;
    }

    // Update is called once per frame
    void Update()
    {
        currentTimer += Time.deltaTime;
        currentTimeAlive += Time.deltaTime;
        if (currentTimer > respawnTimer)
        {
            currentAlive = targets[Random.Range(0, targets.Length - 1)];
            foreach (Transform child in currentAlive.transform)
            {
                if (child.name != "ring")
                    child.GetComponent<MeshRenderer>().enabled = true;
                else if (child.name == "ring")
                {
                    child.GetComponent<MeshCollider>().enabled = true;
                }
            }

            currentTimer = -timeAlive;
            currentTimeAlive = 0;
        }
        if (currentTimeAlive > timeAlive)
        {
            foreach (Transform child in currentAlive.transform)
            {

                if (child.name != "ring")
                    child.GetComponent<MeshRenderer>().enabled = false;
                else if (child.name == "ring")
                {
                    child.GetComponent<MeshCollider>().enabled = false;
                }
            }
            currentTimer = 0;
            currentTimeAlive = -respawnTimer;
        }
    }
}
