using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using ReadyPlayerMe;
using UnityEngine;

public class Orbit: MonoBehaviour
{
    public float radius = 15f;
    public float orbitspeed = 0.01f;
    public float rotatespeed = 0.1f;
    public Transform target;
    private float theta = 0.0f;
    private float x;
    private float z;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        x = radius * Mathf.Cos(theta);
        z = radius * Mathf.Sin(theta);
        transform.position = new Vector3(x, 0, z) + target.position;
        theta += orbitspeed;
        theta %= 360.0f;
        transform.Rotate(Vector3.up, rotatespeed);
    }
}
