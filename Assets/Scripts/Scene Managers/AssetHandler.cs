using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetHandler : MonoBehaviour
{
    public List<Sprite> area0Ingredients = new List<Sprite>();
    public List<Sprite> area1Ingredients = new List<Sprite>();
    public List<Sprite> area2Ingredients = new List<Sprite>();
    public List<Sprite> area3Ingredients = new List<Sprite>();

    public List<Sprite> areaSprites = new List<Sprite>();

    public int area = 0;

    public Soup soup = null;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(area);
        //if (GameObject.FindGameObjectWithTag("Soup").GetComponent<Soup>() != null)
        //{
        //    soup = GameObject.FindGameObjectWithTag("Soup").GetComponent<Soup>();
        //}
    }

    public void changeIngredients()
    {
        if (GameObject.FindGameObjectWithTag("Soup").GetComponent<Soup>() != null)
        {
            soup = GameObject.FindGameObjectWithTag("Soup").GetComponent<Soup>();
        }

        if (area < areaSprites.Count)
        {
            GameObject.FindGameObjectWithTag("Canvas").GetComponent<SpriteRenderer>().sprite = areaSprites[area];
        }

        List<Sprite> ingredients = null;
        switch(area)
        {
            case 0:
                ingredients = area0Ingredients;
                break;
            case 1:
                ingredients = area1Ingredients;
                break;
            case 2:
                ingredients = area2Ingredients;
                break;
            case 3:
                ingredients = area3Ingredients;
                break;
        }

        foreach (var v in soup.ingredientList)
        {
            v.gameObject.GetComponent<SpriteRenderer>().sprite = null;
        }

        if (ingredients != null)
        {
            for (int i = 0; i < ingredients.Count; i++)
            {
                soup.ingredientList[i].gameObject.GetComponent<SpriteRenderer>().sprite = ingredients[i];
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
