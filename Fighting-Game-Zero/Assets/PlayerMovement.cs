using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 6f;
    CharacterController controller;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            controller.Move(transform.right * Input.GetAxisRaw("Horizontal") * Time.deltaTime * playerSpeed);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            controller.Move(transform.right * Time.deltaTime * playerSpeed * 10 + 
                            transform.forward * Time.deltaTime * playerSpeed * 10);
                            // TODO: rotate to face opponent
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            animator.ResetTrigger("leftPunch");
            animator.SetTrigger("leftPunch");
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            animator.ResetTrigger("rightPunch");
            animator.SetTrigger("rightPunch");
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            animator.ResetTrigger("leftKick");
            animator.SetTrigger("leftKick");
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            animator.ResetTrigger("rightKick");
            animator.SetTrigger("rightKick");
        }
    }
}
