using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using Unity.VisualScripting;
using TMPro;

public class Patron : MonoBehaviour
{
    
    //[SerializeField] string name;
    //[SerializeField] Food order;
    //[SerializeField] private List<Sprite> spriteList;
    private Image renderer;
    //private bool isServed;
    private Soup soup;
    public List<Sprite> sprites;
    public List<GameObject> order;
    private int maxIngredients = 3;
    private float timer = 30f;
    private float timerConstant = 30f;

    public bool[] ingredients = new bool[4];

    //PROPERTIES
    //public string Name {get; set;}
    //public Food Order {get; set;}
    //public string OrderName {get {return order.Name;}}

    private void Start()
    {
        renderer = GetComponent<Image>();
        soup = GameObject.FindGameObjectWithTag("Soup").GetComponent<Soup>();
        GameObject.FindGameObjectWithTag("Player").GetComponent<AssetHandler>().changeIngredients(order);
        GeneratePatron();
    }

    private void FixedUpdate()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            GeneratePatron();
        }
    }

    public void GenerateOrder()
    {
        int max = GameObject.FindGameObjectWithTag("Player").GetComponent<AssetHandler>().levelIngredientCount();
        for(int i = 0; i < maxIngredients; i++)
        {
            int sel = Random.Range(0, max + 1);
            order[sel].GetComponent<SpriteRenderer>().enabled = true;
            ingredients[sel] = true;
        }
    }

    public void GiveSoup()
    {
        double timeMod = Mathf.Round(timerConstant / 3);

        GameObject.FindGameObjectWithTag("Player").GetComponent<Game>().points += CheckOrder() * timeMod;
        soup.giveSoup();
        GeneratePatron();
    }

    public double CheckOrder() 
    {
        int score = 0;

        if(soup.bowl && soup.broth)
        {
            score += 20;
        }

        for (int i = 0; i < ingredients.Length; i++)
        {
            if (ingredients[i] && soup.ingredientList[i].GetComponent<SpriteRenderer>().enabled == true)
            {
                score += 20;
            }
        }

        return score;
    }
    public void GeneratePatron() 
    {
        //Generating random number for Patron's sprite (will move this to a GameManager later)
        int j = Random.Range(0, sprites.Count);
        renderer.sprite = sprites[j];

        foreach (GameObject go in order)
        {
            go.GetComponent<SpriteRenderer>().enabled = false;
        }

        for (int i = 0; i < ingredients.Length; i++)
        {
            ingredients[i] = false;
        }

        GenerateOrder();

        timer = timerConstant;

        //order = new Food();
    }
}

//I am not going to use this cause I have no idea what I am supposed to do with this
