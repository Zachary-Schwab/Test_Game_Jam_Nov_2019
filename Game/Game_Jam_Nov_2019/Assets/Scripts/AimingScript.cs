using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimingScript : MonoBehaviour
{
    public float _turningDegreesPerSecond;
    public float _angleRange;

    float _angle;
    float input;

    public float _fireRate;
    float _firingCooldown = 0;
    public float _spread;

    public GameObject _projectilePrefab;

    public AmmoScript ammoScript;
    public KeyCode turretTurnLeft;
    public KeyCode turretTurnRight;
    public KeyCode fire;

    // Start is called before the first frame update
    void Start()
    {
        _angle = 90 -_angleRange;
        input = transform.rotation.eulerAngles.z;
       // ammoScript = GameObject.Find("Tank_Gun").GetComponent<AmmoScript>();
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();

        TickFiringCooldown();
        if (Input.GetKey(fire))
        {
            TryFire();
        }
    }

    void Rotate()
    {
        bool u = Input.GetKey(turretTurnLeft);
        bool o = Input.GetKey(turretTurnRight);

        if(o)
        {
            input += (_turningDegreesPerSecond * Time.deltaTime);

            if(input > _angleRange)
            {
                input = _angleRange;
            }

        }
        else if(u)
        {
            input -= (_turningDegreesPerSecond * Time.deltaTime);

            if (input < -_angleRange)
            {
                input = -_angleRange;
            }
        }

        transform.rotation = Quaternion.Euler(input, transform.rotation.eulerAngles.y, 0f);
    }
    private void TryFire()
    {
        if (_firingCooldown <= 0)
        {
            Fire();
            _firingCooldown = 1 / _fireRate;
        }
    }

    private void TickFiringCooldown()
    {
        _firingCooldown -= Time.deltaTime;
    }

    private void Fire()
    {
        if (ammoScript.removeAmmo())
        {
            float angleToFire = UnityEngine.Random.Range(-_spread, _spread);
            GameObject proj = Instantiate(_projectilePrefab, transform.position, transform.rotation * Quaternion.Euler(0, 0, angleToFire));
            proj.transform.Translate(0, 0, transform.localScale.z + 2f);
        }
    }

}
