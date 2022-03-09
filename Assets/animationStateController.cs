using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isTurningRight = animator.GetBool("isTurningRight");
        bool isTurningLeft = animator.GetBool("isTurningLeft");
        bool isRunning = animator.GetBool("isRunning");
        bool isWalking = animator.GetBool("isWalking");
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");
        bool leftPressed = Input.GetKey("a");
        bool rightPressed = Input.GetKey("d");

        bool jumpPressed = Input.GetKey("space");
        if(jumpPressed)
        {
            animator.SetBool("isJumping", true);
        }
        if (!jumpPressed)
        {
            animator.SetBool("isJumping", false);
        }
        
        if (!isWalking && forwardPressed)
        {
            animator.SetBool("isWalking", true);
        }
        if (isWalking && !forwardPressed)
        {
            animator.SetBool("isWalking", false);
        }

        if (!isRunning && (runPressed && forwardPressed))
        {
            animator.SetBool("isRunning", true);
        }
        if (isRunning && (runPressed || forwardPressed))
        { 
            animator.SetBool("isRunning", false);
        }

        if (leftPressed)
        {
            animator.SetBool("isTurningLeft", true);
        }
        if (!leftPressed)
        {
            animator.SetBool("isTurningLeft", false);
        }
        if (rightPressed)
        {
            animator.SetBool("isTurningRight", true);
        }
        if (!rightPressed)
        {
            animator.SetBool("isTurningRight", false);
        }


    }
}
