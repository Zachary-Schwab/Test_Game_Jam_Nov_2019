using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    Rigidbody _rb;
    public float _movementSpeed = 1.0f;
    public float _rotateSpeed = 12.0f;

    bool IsMoving { get { return _rb.velocity != Vector3.zero; } }

    //float rotDir = 0; //-1 = CW, 1 = CCW
    //bool turnLeft = false;
    //bool turnRight = false;

    // Start is called before the first frame update

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        TryRotate();
    }

    private void TryRotate()
    {
        if (IsMoving)
        {
            float rotDir = 0; //-1 = CW, 1 = CCW
            bool turnLeft = false;
            bool turnRight = false;

            turnLeft = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);
            turnRight = Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);

            rotDir += turnLeft ? 0 : 1;
            rotDir -= turnRight ? 0 : 1;
            transform.Rotate(0f, rotDir * (_rotateSpeed * 10) * Time.deltaTime, 0f);
        }

        _rb.angularVelocity = new Vector3(0f,0f,0f);
    }


    void Move()
    {
        float vertInput = Input.GetAxis("Vertical");

        _rb.velocity = transform.forward * vertInput * _movementSpeed;
        //_rb.velocity = new Vector3(vertInput * _movementSpeed * 10f * Time.deltaTime, 0f, 0f);
    }
}
