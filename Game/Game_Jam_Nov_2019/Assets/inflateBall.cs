using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inflateBall : MonoBehaviour
{
    public Vector3 maxScale;
    public float inflationSpeed;

    public bool shouldInflate;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(shouldInflate)
        {
            Inflate();
        }

        if(transform.localScale.x > maxScale.x && transform.localScale.y > maxScale.y && transform.localScale.z > maxScale.z)
        {
            shouldInflate = false;
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Floor")
        {
            shouldInflate = true;
        }
    }

    void Inflate()
    {
        
        Vector3 time = new Vector3(Time.deltaTime* inflationSpeed, Time.deltaTime * inflationSpeed, Time.deltaTime * inflationSpeed);

        transform.localScale += time;
    }
}
