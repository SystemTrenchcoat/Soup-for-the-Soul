using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Food", menuName = "ScriptableObjects/New Food")]
public class Food : ScriptableObject
{
    /*Whenever a food is crafted through ingredients
    An object will be instantiated with the name and picture of the food
    Then deleted after giving it to the patron
    */
    [SerializeField] string name;
    [SerializeField] Sprite foodImage;
    [SerializeField] List<Ingredients> recipe = new List<Ingredients>(); //The ingredients in the pot has to match these!

    public string Name {get {return name;} set {name = value;} }
    public Sprite FoodImage {get {return foodImage;} set {foodImage = value;} }
    public List<Ingredients> Recipe {get {return recipe;} set {recipe = value;} }
}

