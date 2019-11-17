using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public CharacterController characterController;

    public float speed = 10f, jumpSpeed = 10f;

    public float gravity = -1f;

    private Vector3 velocity;
    


    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        characterController.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        characterController.Move(velocity);

        if (characterController.isGrounded)
        { 
            velocity.y = 0f;
            
            if (Input.GetButton("Jump"))
            {
                velocity.y = jumpSpeed * Time.deltaTime;
            }
            
        }
      
            



    }
}
