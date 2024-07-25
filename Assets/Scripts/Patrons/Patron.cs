using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using Unity.VisualScripting;
using TMPro;

public class Patron : MonoBehaviour
{
    
    [SerializeField] string name;
    [SerializeField] Food order;
    [SerializeField] private List<Sprite> spriteList;
    private Image renderer;
    private bool isServed;

    //PROPERTIES
    public string Name {get; set;}
    public Food Order {get; set;}
    public string OrderName {get {return order.Name;}}

    private void Start()
    {
        renderer = GetComponent<Image>();
    }
    public void CheckOrder() 
    {

    }
    public void GeneratePatron() 
    {
        //Generating random number for Patron's sprite (will move this to a GameManager later)
        int j = Random.Range(0, spriteList.Count - 1);
        renderer.sprite = spriteList[j];

        
    }
}

//I am not going to use this cause I have no idea what I am supposed to do with this
