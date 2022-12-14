using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class RotateCam : MonoBehaviour
{
    public float radius = 15f;
    public float orbitspeed = 0.01f;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.RotateAround(target.position, Vector3.up, orbitspeed);
        transform.LookAt(target);
    }
}
