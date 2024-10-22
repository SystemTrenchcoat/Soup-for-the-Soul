using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using Unity.VisualScripting;
using TMPro;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class Patron : MonoBehaviour
{
    
    //[SerializeField] string name;
    //[SerializeField] Food order;
    //[SerializeField] private List<Sprite> spriteList;
    private Image renderer;
    //private bool isServed;
    private Soup soup;
    public List<GameObject> order;
    private int maxIngredients = 3;
    private float timer = 30f;
    private float timerConstant = 30f;

    public bool[] ingredients = new bool[4];
    public List<Sprite> sprites = new List<Sprite>();
    SpriteManager spriteManager;

    //PROPERTIES
    //public string Name {get; set;}
    //public Food Order {get; set;}
    //public string OrderName {get {return order.Name;}}

    private void Start()
    {
        //spriteM = SpriteManager.instance;
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
        //Debug.Log(max);
        for (int i = 0; i < maxIngredients; i++)
        {
            int sel = Random.Range(0, max);// + 1);
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
        int max = 20;

        if(soup.bowl && soup.broth)
        {
            score += 20;
        }

        for (int i = 0; i < ingredients.Length; i++)
        {
            if (ingredients[i])
            {
                if (soup.ingredientList[i].GetComponent<SpriteRenderer>().enabled == true)
                {
                    score += 20;
                }
                

                max += 20;
            }
        }

        bool correct = false;

        if (score == max)
        {
            correct = true;
        }

        if (timer <= timerConstant / 2)
        {
            score = score / 2;
        }

        //Debug.Log(score);
        //Debug.Log(max);
        GetComponent<Patronv2>().ServePatron(correct);
        return score * (1 + GameObject.FindGameObjectWithTag("Player").GetComponent<Upgrades>().PopularityIncrease);
    }
    
    public void GeneratePatron() 
    {
        //Generating random number for Patron's sprite (will move this to a GameManager later)
        int j = Random.Range(0, sprites.Count);

        foreach(GameObject go in GameObject.FindGameObjectsWithTag("Patron"))
        {
            if (go != this)
            {
                do
                {
                    j = Random.Range(0, sprites.Count);
                } while (go.GetComponent<Image>().sprite == sprites[j]);
            }
        }

        GetComponent<Image>().sprite = sprites[j];
        //Debug.Log("Generate");

        foreach (GameObject go in order)
        {
            //Debug.Log(go.name);
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
