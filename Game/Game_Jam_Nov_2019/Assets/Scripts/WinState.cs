using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinState : MonoBehaviour
{
    public float score;
    public Vector3 scoreCenter;
    public Vector3 scoreSize;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Collider[] collidingObjects = Physics.OverlapBox(scoreCenter, scoreSize/2, Quaternion.identity);
        if (collidingObjects != null && collidingObjects.Length > 0)
        {
            score = 0;
            foreach (Collider collider in collidingObjects)
            {
                if (collider.gameObject.tag == "ball")
                {
                    score++;
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireCube(scoreCenter, scoreSize);
    }
}
