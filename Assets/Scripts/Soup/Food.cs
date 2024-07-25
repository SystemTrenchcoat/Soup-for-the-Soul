using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Food : MonoBehaviour
{
    /*Whenever a food is crafted through ingredients
    An object will be instantiated with the name and picture of the food
    Then deleted after giving it to the patron
    */
    [SerializeField] private string name;
    [SerializeField] private Ingredients[] recipe; //The ingredients in the pot has to match these!
    private IngredientManager ingredientManager;

    public void Start() 
    {
        ingredientManager = FindAnyObjectByType<IngredientManager>();
    }

    public string Name {get {return name;} set {name = value;} }
    public Ingredients[] Recipe {get {return recipe;} set {recipe = value;} }
    
    //Constructor
    public Food() 
    {
        recipe = ingredientManager.GenerateIngredientArray();
    }
}

