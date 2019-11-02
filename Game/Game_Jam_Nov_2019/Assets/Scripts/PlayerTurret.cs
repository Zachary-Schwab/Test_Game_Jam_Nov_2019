using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurret : MonoBehaviour
{

    public float _turningDegreesPerSecond;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        bool i = Input.GetKey(KeyCode.I);
        bool j = Input.GetKey(KeyCode.J);
        bool k = Input.GetKey(KeyCode.K);
        bool l = Input.GetKey(KeyCode.L);
        if (i || j || k || l)
        {
            int y = 0;
            y += i ? 1 : 0;
            y -= k ? 1 : 0;
            int x = 0;
            x -= j ? 0 : 1;
            x += l ? 0 : 1;

            float inputAngle = Vector3.SignedAngle(Vector3.right, new Vector3(x, y, 0), Vector3.down);
            if (y < 0)
            {
                inputAngle = -inputAngle;
            }
            float currAngle = (transform.rotation.eulerAngles.z + 90) % 360;

            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, inputAngle - 90, 0), _turningDegreesPerSecond * Time.deltaTime);

            //transform.rotation = Quaternion.Euler(new Vector3(0, 0, targetAngle - 90));
        }
        //move degrees * Time.deltaTime;

        //throw new NotImplementedException();
    }


}
