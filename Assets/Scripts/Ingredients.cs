using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredients : MonoBehaviour
{
    [SerializeField] string name;
    [SerializeField] string description;
    [SerializeField] int Id;

    public string Name {get; set;}
    public string Description {get; set;}
    public int ID {get; set;}
}
