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
        //Vector3 mousePos = Vector3.zero;

        crosshairPos = new Vector2(Screen.width / 2.0f, Screen.height / 2.0f);

        Ray ray = Camera.main.ScreenPointToRay(crosshairPos);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 900.0f, aimLayer))
        {
            random.position = hit.point;
        }

        //Vector3 crosshairTarget = mousePos;
        //crosshairTarget.y = transform.position.y;
        //Vector3 aimDirection = (crosshairTarget - transform.position).normalized;

        //transform.forward = Vector3.Lerp(transform.forward, aimDirection, Time.deltaTime * 20.0f);
    }
}
