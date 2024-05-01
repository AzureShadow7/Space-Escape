using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputSystem : MonoBehaviour
{
    private Rigidbody playerRB;
    public Transform orientation;
    private PlayerInput playerInputs;
    private PlayerInputActions playerInputActions;

    public float walkForce = 5.0f;
    public float jumpForce = 5.0f;
    

    private void Awake()
    {
        playerRB = GetComponent<Rigidbody>();
        playerInputs = GetComponent<PlayerInput>();

        playerInputActions = new PlayerInputActions();
        playerInputActions.PlayerActions.Enable();
        playerInputActions.PlayerActions.Jump.performed += Jump;
    }

    private void Update()
    {
        
        float forward = playerInputActions.PlayerActions.MoveForward.ReadValue<float>();
        float right = playerInputActions.PlayerActions.MoveRight.ReadValue<float>();

        Vector3 moveDirection = transform.right * right + transform.forward * forward;
        playerRB.velocity = new Vector3(moveDirection.x, playerRB.velocity.y, moveDirection.z);
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("I'm Jumping" + context.phase);
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        
    }

}
