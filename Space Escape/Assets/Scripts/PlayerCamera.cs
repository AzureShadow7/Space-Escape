using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.InputSystem;

public class PlayerCamera : MonoBehaviour
{
    private float xRotation;
    private float yRotation;
    public float mouseSpeed = 10.0f;
    public Transform orientation;

    private PlayerInputActions playerInputActions;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.LookActions.Enable();
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float mouseX = playerInputActions.LookActions.MouseX.ReadValue<float>() * mouseSpeed * Time.deltaTime;
        float mouseY = playerInputActions.LookActions.MouseY.ReadValue<float>() * mouseSpeed * Time.deltaTime;

        xRotation -= mouseY;
        yRotation += mouseX;

        xRotation = Mathf.Clamp(xRotation, -90.0f, 45.0f);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        orientation.Rotate(Vector3.up * mouseX);
    }
}
