using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientManager : MonoBehaviour
{
    [SerializeField] List<Ingredients> ingredientList = new List<Ingredients>();

    public Ingredients[] GenerateIngredientArray() 
    {
        int randomNum = UnityEngine.Random.Range(0, 3);
        Ingredients[] arr = new Ingredients[randomNum];

        for(int i = 0; i < randomNum; i++) 
        {
            int randomIng = UnityEngine.Random.Range(0, ingredientList.Count - 1);
            arr[i] = ingredientList[randomIng];
        }
        return arr;
    }
}
