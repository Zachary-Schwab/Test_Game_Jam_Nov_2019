using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (this.transform.parent.gameObject.tag == "Blue")
        {
            GameObject.Find("TankHeadTextured").GetComponent<AmmoScript>().addAmmo(2);
            foreach (Transform child in this.transform.parent.transform)
            {

                if (child.name != "ring")
                    child.GetComponent<MeshRenderer>().enabled = false;
                else if (child.name == "ring")
                {
                    child.GetComponent<MeshCollider>().enabled = false;
                }
            }
        }

        if (this.transform.parent.gameObject.tag == "Red")
        {
            GameObject.Find("Tank_Gun").GetComponent<AmmoScript>().addAmmo();
            foreach (Transform child in this.transform.parent.transform)
            {

                if (child.name != "ring")
                    child.GetComponent<MeshRenderer>().enabled = false;
                else if (child.name == "ring")
                {
                    child.GetComponent<MeshCollider>().enabled = false;
                }
            }

        }
        this.gameObject.GetComponent<AudioSource>().Play();
    }
}
