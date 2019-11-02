using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalMovement : MonoBehaviour
{
    public float movementSpeed = .1f;
    public float rotationSpeed = .1f;
    public float minX = -10f;
    public float maxX = 10f;
    public int state = 1;
    public float probabilityOfDirectionChange = 1;
    public float radius = 4;
    public bool goingLeft;
    public bool rotate;
    float c;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = this.transform.position;
        c = (minX + maxX) / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x > maxX)
        {
            goingLeft = true;
        }
        if (this.transform.position.x < minX)
        {
            goingLeft = false;
        }
        switch (state)
        {
           case 1:
                if(goingLeft)
                {
                    this.transform.position = new Vector3(this.transform.position.x - movementSpeed, this.transform.position.y, this.transform.position.z);
                }
                else
                {
                    this.transform.position = new Vector3(this.transform.position.x + movementSpeed, this.transform.position.y, this.transform.position.z);
                }
                break;
        case 2:
                float rando = Random.Range(0f,1f);
                if (goingLeft)
                {
                    if (rando >= (100-probabilityOfDirectionChange) / 100)
                        goingLeft = false;
                    else
                        this.transform.position = new Vector3(this.transform.position.x - movementSpeed, this.transform.position.y, this.transform.position.z);       
                }
                else
                {
                    if (rando >= (100 - probabilityOfDirectionChange) / 100)
                        goingLeft = true;
                    else
                        this.transform.position = new Vector3(this.transform.position.x + movementSpeed, this.transform.position.y, this.transform.position.z);
                }
            break;
        case 3:
                float distance = Mathf.Abs(c - transform.position.x);
                if(Mathf.Abs(distance - radius) <= movementSpeed && distance > radius - movementSpeed)
                {
                    rotate = true;
                }
                if ((this.transform.position.x > (c) + radius || (this.transform.position.x >= (c) - radius && this.transform.position.x <= c)) && !rotate)
                {
                    this.transform.position = new Vector3(this.transform.position.x - movementSpeed, this.transform.position.y, this.transform.position.z);

                }
                else if ((this.transform.position.x < ((minX + maxX)/ 2) - radius || (this.transform.position.x < (c) + radius && this.transform.position.x > c)) && !rotate)
                {
                    this.transform.position = new Vector3(this.transform.position.x + movementSpeed, this.transform.position.y, this.transform.position.z);
                }
                else
                {
                    Debug.Log("trying to rotatae");
                    this.transform.RotateAround(new Vector3((minX + maxX)/2, startPos.y, startPos.z), Vector3.forward, rotationSpeed * Time.deltaTime);
                }
                break;
        }
    }
    public void CheckState(int score)
    {
        if (score > 5)
        {
            state = 2;
        }
        if (score > 12)
        {
            state = 3;
        }
    }
}
