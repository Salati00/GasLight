using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    public float cameraDistOffset = 10;
    public float sensitivity = 10;
    public float cameraHeight = 4;

    private Vector3 offset;

    // Use this for initialization
    void Start()
    {
        offset = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z + cameraDistOffset);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void LateUpdate()
    {
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * sensitivity, Vector3.up) * offset;
        offset.y = 0;
        transform.position = player.transform.position + (offset*0.02f);
        Vector3 yoffset = new Vector3(0, cameraHeight, 0);
        transform.position = transform.position + yoffset;
        transform.LookAt(player.transform.position);
    }
}
