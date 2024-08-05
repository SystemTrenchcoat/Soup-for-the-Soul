using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetHandler : MonoBehaviour
{
    public List<Sprite> area0Ingredients = new List<Sprite>();
    public List<Sprite> area1Ingredients = new List<Sprite>();
    public List<Sprite> area2Ingredients = new List<Sprite>();
    public List<Sprite> area3Ingredients = new List<Sprite>();

    public List<Sprite> area0Soups = new List<Sprite>();
    public List<Sprite> area1Soups = new List<Sprite>();
    public List<Sprite> area2Soups = new List<Sprite>();
    public List<Sprite> area3Soups = new List<Sprite>();

    public List<Sprite> areaSprites = new List<Sprite>();

    public List<float> areaTimer = new List<float>();

    public int area = 0;

    //public Soup soup = null;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(area);
        //if (GameObject.FindGameObjectWithTag("Soup").GetComponent<Soup>() != null)
        //{
        //    soup = GameObject.FindGameObjectWithTag("Soup").GetComponent<Soup>();
        //}
    }

    public int levelIngredientCount()
    {
        int count = 0;

        switch (area)
        {
            case 0:
                count = area1Ingredients.Count;
                break;
            case 1:
                count = area2Ingredients.Count;
                break;
            case 2:
                count = area3Ingredients.Count;
                break;
            case 3:
                count = area0Ingredients.Count;
                break;
        }

        return count;
    }

    public void changeIngredients(List<GameObject> ingredientList)
    {
        //if (GameObject.FindGameObjectWithTag("Soup").GetComponent<Soup>() != null)
        //{
        //    soup = GameObject.FindGameObjectWithTag("Soup").GetComponent<Soup>();
        //}

        if (area < areaSprites.Count)
        {
            GameObject.FindGameObjectWithTag("Canvas").GetComponent<SpriteRenderer>().sprite = areaSprites[area];
        }

        List<Sprite> ingredients = null;
        switch(area)
        {
            case 0:
                ingredients = area1Ingredients;
                GetComponent<Game>().levelTimer = areaTimer[0];
                break;
            case 1:
                ingredients = area2Ingredients;
                GetComponent<Game>().levelTimer = areaTimer[1];
                break;
            case 2:
                ingredients = area3Ingredients;
                GetComponent<Game>().levelTimer = areaTimer[2];
                break;
            case 3:
                ingredients = area0Ingredients;
                GetComponent<Game>().levelTimer = areaTimer[3];
                break;
        }

        foreach (var v in ingredientList)
        {
            v.GetComponent<SpriteRenderer>().sprite = null;
        }

        if (ingredients != null)
        {
            for (int i = 0; i < ingredients.Count; i++)
            {
                ingredientList[i].gameObject.GetComponent<SpriteRenderer>().sprite = ingredients[i];
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
