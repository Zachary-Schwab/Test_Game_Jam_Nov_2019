using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Goal_Collide : MonoBehaviour
{
    public int score;
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
        if(collision.gameObject.tag == "ball")
        {
            Destroy(collision.gameObject);
            score++;
            this.gameObject.GetComponent<DropBalls>().DropBall();
        }
    }
}
