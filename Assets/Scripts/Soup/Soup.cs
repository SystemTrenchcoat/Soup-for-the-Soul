using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using static UnityEditor;

public class Soup : MonoBehaviour
{
    public Sprite Bowl;
    public Sprite FilledBowl;

    public bool bowl = false;
    public bool broth = false;
    public bool[] ingredients = new bool[4];
    public List<GameObject> ingredientList = new List<GameObject>();

    public void addBowl()
    {
        bowl = true;
        GetComponent<SpriteRenderer>().enabled = true;
        GetComponent<SpriteRenderer>().sprite = Bowl;
        //Debug.Log("Bowl Placed");
    }

    public void addBroth()
    {
        broth = true;
        GetComponent<SpriteRenderer>().sprite = FilledBowl;
        //Debug.Log("Filled Soup");
    }

    public void addIngredient(int i)
    {
        //Debug.Log(i);
        //ingredients[i] = true;
        if (ingredientList[i].GetComponent<SpriteRenderer>().sprite != null)
        {
            //ingredientList[i].GetComponent<SpriteRenderer>().enabled = true;
            ingredients[i] = true;
        }
    }

    public void giveSoup()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        foreach (GameObject go in ingredientList)
        {
            go.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;

        foreach (var item in ingredientList)
        {
            item.GetComponent<SpriteRenderer>().enabled = false;
        }

        GameObject.FindGameObjectWithTag("Player").GetComponent<AssetHandler>().changeIngredients(ingredientList);
    }

    // Update is called once per frame
    void Update()
    {

    }
}