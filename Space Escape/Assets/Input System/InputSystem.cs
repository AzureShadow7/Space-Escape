using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputSystem : MonoBehaviour
{
    private Rigidbody playerRB;
    
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
        Vector2 moveDirection = playerInputActions.PlayerActions.Movement.ReadValue<Vector2>();
        this.transform.Translate(new Vector3(moveDirection.x, 0, moveDirection.y) * walkForce * Time.deltaTime);
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
