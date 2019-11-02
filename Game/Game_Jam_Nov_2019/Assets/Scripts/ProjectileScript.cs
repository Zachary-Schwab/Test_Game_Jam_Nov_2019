using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public float _maxLifespan;
    public float _projectileSpeed;

    private float _currLifespan;
    private Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.velocity = _projectileSpeed * transform.right;
        _currLifespan = _maxLifespan;
    }

    // Update is called once per frame
    void Update()
    {
        if (_currLifespan <= 0)
        {
           // Destroy(gameObject);
        }
        else
        {
            _currLifespan -= Time.deltaTime;
        }
    }

    void onCollisionEnter(Collision col)
    {
        
    }
}
