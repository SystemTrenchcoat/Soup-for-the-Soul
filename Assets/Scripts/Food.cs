using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Food", menuName = "ScriptableObjects/New Food")]
public class Food : ScriptableObject
{
    [SerializeField] string name;
    [SerializeField] Sprite foodImage;
    [SerializeField] List<Ingredients> recipe = new List<Ingredients>();

    public string Name {get {return name;} set {name = value;} }
    public Sprite FoodImage {get {return foodImage;} set {foodImage = value;} }
    public List<Ingredients> Recipe {get {return recipe;} set {recipe = value;} }
}

