using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class InputHandler : MonoBehaviour
{
    private Camera mainCamera;
    public Image orderInfo;
    [SerializeField] TMP_Text orderName;
    [SerializeField] Image foodPic;

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
        foodPic.GetComponent<Image>().sprite = rayHit.collider.gameObject.GetComponent<Customer>().OrderPic;

        }
    }
}