using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float min = 0.291f;
    public float max = 5f;
        public float movementSpeed = 2;
    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        min = transform.position.x;
        max = transform.position.x + 15;
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 to = new Vector3(0, 180, 0);
        Vector3 endPosition = new Vector3(max, transform.position.y, transform.position.z);
        Vector3 startPosition = new Vector3(min, transform.position.y, transform.position.z);

        if (transform.position != endPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPosition, movementSpeed * Time.deltaTime);

        }
        if (transform.position == endPosition)
        {
            transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime);
        }
        if(transform.rotation.y == 170)
        {
            Debug.Log(transform.position.ToString());
            transform.position = Vector3.MoveTowards(transform.position, startPosition, movementSpeed * Time.deltaTime);

        }
        //transform.position = Vector3.MoveTowards(transform.position, startPosition, movementSpeed * Time.deltaTime);


        //transform.position = new Vector3(Mathf.PingPong(Time.time * 1, max - min) + min, transform.position.y, transform.position.z);
        //transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime);
    }
}
