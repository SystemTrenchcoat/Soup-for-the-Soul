using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class InputHandler : MonoBehaviour
{
    private Camera mainCamera;
    public Image orderInfo;
    [SerializeField] TMP_Text orderName;
    [SerializeField] TMP_Text orderDesc;

    private void Awake() {
        mainCamera = Camera.main;
    }
    public void OnClick(InputAction.CallbackContext context) 
    {
        if(!context.started) return;

        var rayHit = Physics2D.GetRayIntersection(mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue()));
        if(!rayHit.collider) return;

        Debug.Log(rayHit.collider.gameObject.name);

    if(rayHit.collider.gameObject.GetComponent<Customer>() != null) {
        orderInfo.gameObject.SetActive(true);
        orderName.text = rayHit.collider.gameObject.GetComponent<Customer>().OrderName;
        orderDesc.text = rayHit.collider.gameObject.GetComponent<Customer>().OrderDesc;
        }
    }
}
