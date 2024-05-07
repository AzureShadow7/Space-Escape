using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EnemyDetection : MonoBehaviour
{
    private PlayerInputActions playerInputActions;

    // Start is called before the first frame update
    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.SpecialActions.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DetectEnemy(InputAction.CallbackContext context)
    {
        Debug.Log("An enemy is near");
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Enemy")
        {
            playerInputActions.SpecialActions.DetectEnemy.performed += DetectEnemy;
        }
    }
}
