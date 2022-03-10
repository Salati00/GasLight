using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float torque = 10;


    public float rotationSpeed = 10;
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody body = GetComponent<Rigidbody>();

        float hor = Input.GetAxis("Horizontal") * moveSpeed;
        float ver = Input.GetAxis("Vertical") * moveSpeed;

        body.AddForce(new Vector3(hor, 0.0f, ver));
    }



}
