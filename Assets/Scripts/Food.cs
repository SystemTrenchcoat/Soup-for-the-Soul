using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Food", menuName = "ScriptableObjects/New Food")]
public class Food : ScriptableObject
{
    [SerializeField] string name;
    [SerializeField] string description;
    [SerializeField] List<Ingredients> recipe = new List<Ingredients>();

    public string Name {get {return name;} set {name = value;} }
    public string Description {get {return description;} set {description = value;} }
    public List<Ingredients> Recipe {get {return recipe;} set {recipe = value;} }
}

