using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamera : MonoBehaviour
{
    public GameObject target;

    public Transform cam;
    public Transform player;

    public Vector3 targetMovementOffset;
    public Vector3 targetLookAtOffset;

    public float springForce;
    public float springDamper;

    void Start()
    {
        //
    }

    void Update()
    {
        //Rigidbody body = this.GetComponent<Rigidbody>();

        //Vector3 diff = transform.position - (target.transform.position + targetMovementOffset);
        //Vector3 vel = body.velocity;

        //Vector3 force = (diff * -springForce) - (vel * springDamper);

        //body.AddForce(force);

        //GameObject parent = this.transform.parent.gameObject;
        //transform.LookAt(parent.transform.position);

        cam.position = player.position + new Vector3(0, 10, -15);
    }
}

