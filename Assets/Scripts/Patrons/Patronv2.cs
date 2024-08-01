using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Patronv2 : MonoBehaviour
{
    private Image renderer;
    private Soup soup;
    public List<GameObject> order;
    private int maxIngredients = 3;
    private float timer = 30f;
    private float timerConstant = 30f;

    public bool[] ingredients = new bool[4];
    SpriteManager spriteM;

    // New fields for handling sound effects
    public PatronSoundManager soundManager;
    private bool hasBeenServed = false;
    private bool isServedCorrectly = false;

    private void Start()
    {
        spriteM = SpriteManager.instance;
        renderer = GetComponent<Image>();
        soup = GameObject.FindGameObjectWithTag("Soup").GetComponent<Soup>();
        GameObject.FindGameObjectWithTag("Player").GetComponent<AssetHandler>().changeIngredients(order);
        GeneratePatron();
    }

    private void FixedUpdate()
    {
        if (!hasBeenServed)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                PlayUpsetSound();
                GeneratePatron();
            }
        }
    }

    public void GenerateOrder()
    {
        int max = GameObject.FindGameObjectWithTag("Player").GetComponent<AssetHandler>().levelIngredientCount();
        for (int i = 0; i < maxIngredients; i++)
        {
            int sel = Random.Range(0, max + 1);
            order[sel].GetComponent<SpriteRenderer>().enabled = true;
            ingredients[sel] = true;
        }
    }

    public void GiveSoup()
    {
        double timeMod = Mathf.Round(timerConstant / 3);
        double pointsEarned = CheckOrder() * timeMod;
        GameObject.FindGameObjectWithTag("Player").GetComponent<Game>().points += pointsEarned;
        
        isServedCorrectly = pointsEarned >= 100; // Assuming 100 points means the order is correct

        soup.giveSoup();
        PlayReactionSound();

        GeneratePatron();
    }

    public double CheckOrder()
    {
        int score = 0;

        if (soup.bowl && soup.broth)
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
        // Generating random number for Patron's sprite (will move this to a GameManager later)
        Sprite newSprite = spriteM.GenerateSprite();
        renderer.sprite = newSprite;

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
        hasBeenServed = false;
    }

    private void PlayReactionSound()
    {
        if (isServedCorrectly && timer > 0)
        {
            soundManager.PlayHappySound();
        }
        else
        {
            soundManager.PlayUpsetSound();
        }

        hasBeenServed = true;
    }

    private void PlayUpsetSound()
    {
        soundManager.PlayUpsetSound();
        hasBeenServed = true;
    }
}
