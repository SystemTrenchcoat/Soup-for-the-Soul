using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using Unity.VisualScripting;
using TMPro;

public class Customer : MonoBehaviour
{
    
    [SerializeField] string name;
    [SerializeField] Food order;

    public string Name {get; set;}
    public Food Order {get; set;}

    public string OrderName {get {return order.Name;}}
    public Sprite OrderPic {get {return order.FoodImage;}}

}
