using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punishment : MonoBehaviour
{
    WinState redState;
    WinState blueState;
    // Start is called before the first frame update
    void Start()
    {
        redState = GameObject.Find("RedArea").GetComponent<WinState>();
        blueState = GameObject.Find("BlueArea").GetComponent<WinState>();
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colllision detected with death coins");
        if(this.transform.parent.gameObject.tag == "Red")
        {
            Debug.Log("tagRead");
            Collider[] collidingObjects = Physics.OverlapBox(redState.scoreCenter, redState.scoreSize / 2, Quaternion.identity);
            if (collidingObjects != null && collidingObjects.Length > 0)
            {
                foreach (Collider collider in collidingObjects)
                {
                    if (collider.gameObject.tag == "Shootable")
                    {
                        Destroy(collider.gameObject);
                        break;
                    }
                }
            }
        }
        if (this.transform.parent.gameObject.tag == "Blue")
        {
            Collider[] collidingObjects = Physics.OverlapBox(blueState.scoreCenter, blueState.scoreSize / 2, Quaternion.identity);
            if (collidingObjects != null && collidingObjects.Length > 0)
            {
                foreach (Collider collider in collidingObjects)
                {
                    if (collider.gameObject.tag == "Shootable")
                    {
                        Destroy(collider.gameObject);
                        break;
                    }
                }
            }
        }
        this.gameObject.GetComponent<AudioSource>().Play();
        this.transform.parent.gameObject.SetActive(false);
    }
}
