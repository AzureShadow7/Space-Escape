using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAimController : MonoBehaviour
{
    Vector2 crosshairPos;
    [SerializeField] private LayerMask aimLayer = new LayerMask();
    [SerializeField] private Transform random;

    // Update is called once per frame
    void Update()
    {
        crosshairPos = new Vector2(Screen.width / 2.0f, Screen.height / 2.0f);

        Ray ray = Camera.main.ScreenPointToRay(crosshairPos);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 900.0f, aimLayer))
        {
            random.position = hit.point;
        }

    }
}
