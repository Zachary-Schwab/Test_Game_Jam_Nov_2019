using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBalls : MonoBehaviour
{
    public int ballsToDrop = 100;
    public GameObject ball_model;
    public float spawnHeight = 5f;
    public Vector4 dropZoneDimensions;
    public GameObject[] dropLocation;
    // Start is called before the first frame update
    void Start()
    {
        //for (int i = 0; i < ballsToDrop; i++)
        //{
        //    float xSpawnPos = Random.Range(dropZoneDimensions.x, dropZoneDimensions.y);
        //    float zSpawnPos = Random.Range(dropZoneDimensions.z, dropZoneDimensions.w);
        //    GameObject ball = Instantiate(ball_model, new Vector3(xSpawnPos, spawnHeight, zSpawnPos), Quaternion.identity);
        //    ball.GetComponent<Rigidbody>().velocity = Vector3.down * 20f;
        //}
       
    }

    // Update is called once per frame
    void Update()
    {
        //DropBall();
    }
    public void DropBall()
    {
        for(int i =0; i < dropLocation.Length; ++i)
        {
            Instantiate(ball_model, dropLocation[i].transform.position, Quaternion.identity);
        }
    }
}
