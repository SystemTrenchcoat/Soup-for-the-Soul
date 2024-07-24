using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredients : MonoBehaviour
{
    [SerializeField] string name;
    [SerializeField] string description;
    [SerializeField] int Id; 
    /*When an ingredient is added, they will be added to a Hashset
    The hashset will be compared to the food's recipe list
    Was going to use the Id variable for this but it's prob useless*/

    public string Name {get; set;}
    public string Description {get; set;}
    public int ID {get; set;}
}
