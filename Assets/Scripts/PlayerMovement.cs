using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct playerConfig
{
    public int moveForce;
    public int jumpForce;
    public int fireRate;
    public GameObject bullet;
}

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{

    public playerConfig config = new playerConfig();

    private Rigidbody physics;
    private bool isGrounded;
    private bool fireDelay;
    private bool jumpDelay;

    // Start is called before the first frame update
    void Start()
    {
        physics = this.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newRotation = this.transform.eulerAngles;
        newRotation.y = Camera.main.transform.eulerAngles.y;
        this.transform.eulerAngles = newRotation;
    }

    private void FixedUpdate()
    {
        Vector3 controlDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        var actualDirection = Camera.main.transform.TransformDirection(controlDirection);
        actualDirection.y = 0;
        actualDirection.Normalize();

        physics.AddForce(actualDirection * config.moveForce);

        if (Input.GetButton("Jump") && !jumpDelay)
        {
            Debug.Log("Jump");
            jump();
        }
    }

    void OnCollisionEnter(Collision x)
    {
        Debug.Log(x.gameObject.name);
        if (x.gameObject.name == "Roof" || x.gameObject.name == "Terrain")
        {
            isGrounded = true;
        }
    }

    //consider when character is jumping .. it will exit collision.
    void OnCollisionExit(Collision x)
    {
        if (x.gameObject.name == "Roof" || x.gameObject.name == "Terrain")
        {
            isGrounded = false;
        }
    }

    private void jump()
    {
        if (isGrounded)
        {
            Debug.Log("Jumping");
            /*this.GetComponent<AudioSource>()
                .Play();*/
            physics.AddForce(new Vector3(0, 1, 0) * config.jumpForce);
            StartCoroutine(reloadJump());
        }
    }

    private IEnumerator reloadJump()
    {
        jumpDelay = true;
        yield return new WaitForSeconds(0.1f);
        jumpDelay = false;
    }
}
