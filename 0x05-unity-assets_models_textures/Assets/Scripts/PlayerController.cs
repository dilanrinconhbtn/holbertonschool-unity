using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalMove;
    public float verticalMove;
    private Vector3 playerInput;
    float speed = 5f; // units per second
    float turnSpeed = 90f; // degrees per second
    float jumpSpeed = 8f;
    float gravity = 9.8f;
    private float vSpeed = 0; // current vertical velocity

    void Update()
    {


        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
        playerInput = new Vector3(horizontalMove, 0, verticalMove) * speed;
        var controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            vSpeed = 0; // grounded character has vSpeed = 0...
            if (Input.GetKeyDown("space"))
            { // unless it jumps:
                vSpeed = jumpSpeed;
            }
        }
        // apply gravity acceleration to vertical speed:
        vSpeed -= gravity * Time.deltaTime;
        playerInput.y = vSpeed; // include vertical speed in vel
                        // convert vel to displacement and Move the character:
        controller.Move(playerInput * Time.deltaTime);
    }
}
