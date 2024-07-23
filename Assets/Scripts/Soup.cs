using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soup : MonoBehaviour
{
    public Sprite Bowl;
    public Sprite FilledBowl;

    private bool bowl = false;
    private bool broth = false;
    private List<bool> ingredients = new List<bool>();
    public List<GameObject> ingredientList = new List<GameObject>();

    public void addBowl()
    {
        bowl = true;
        gameObject.SetActive(true);
        GetComponent<SpriteRenderer>().sprite = Bowl;
    }

    public void addBroth()
    {
        broth = true;
        GetComponent<SpriteRenderer>().sprite = FilledBowl;
    }

    public void addIngredient(int i)
    {
        ingredients[i] = true;
        ingredientList[i].GetComponent<GameObject>().SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        ////gameObject.SetActive(false);
        //foreach(var item in ingredientList)
        //{
        //    item.GetComponent<GameObject>().SetActive(false);
        //}
    }

    // Update is called once per frame
    void Update()
    {

    }
}