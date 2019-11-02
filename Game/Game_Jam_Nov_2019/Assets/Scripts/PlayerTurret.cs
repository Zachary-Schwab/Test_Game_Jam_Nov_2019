using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurret : MonoBehaviour
{

    public float _turningDegreesPerSecond;
    float input;

    public KeyCode iKey;
    public KeyCode jKey;
    public KeyCode kKey;
    public KeyCode lKey;
    // Start is called before the first frame update
    void Start()
    {
        input = transform.rotation.eulerAngles.z;
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        bool i = Input.GetKey(iKey);
        bool j = Input.GetKey(jKey);
        bool k = Input.GetKey(kKey);
        bool l = Input.GetKey(lKey);
        //if (i || j || k || l)
        //{
        //    int y = 0;
        //    y += i ? 1 : 0;
        //    y -= k ? 1 : 0;
        //    int x = 0;
        //    x -= j ? 0 : 1;
        //    x += l ? 0 : 1;

        //    float inputAngle = Vector3.SignedAngle(Vector3.right, new Vector3(x, y, 0), Vector3.down);
        //    if (y < 0)
        //    {
        //        inputAngle = -inputAngle;
        //    }
        //    float currAngle = (transform.rotation.eulerAngles.z + 90) % 360;

        //    transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, inputAngle - 90, 0), _turningDegreesPerSecond * Time.deltaTime);

        //}
        
        if(l)
        {
            input += (_turningDegreesPerSecond * Time.deltaTime);
        }
        else if(j)
        {
            input -= (_turningDegreesPerSecond * Time.deltaTime);
        }

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, input, 0f);


    }


}
