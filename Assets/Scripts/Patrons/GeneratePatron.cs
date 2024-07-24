using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePatron : MonoBehaviour
{
    public Sprite[] sprites;
    public Sprite[] area1;
    public Sprite[] area2;
    public Sprite[] area3;
    public SpriteRenderer bowl;
    public Sprite bowls;
    public SpriteRenderer soup;


    void Start()
    {
        renderer.enabled = true;
        MakeCustomer();
    }

    void MakeCustomer()
    {
        int i = Random.Range(0,sprites.Length);
        renderer.sprite = sprites[i];
    }

    void GetOrder()
    {
        switch(area)
        {
            case 1:
                int a = Random.Range(0, area1.Length);
                ingredient.sprite = sprites[a];
                bowl.sprite = bowls;
                soup.sprite = soups;
                break;
            case 2:
                int b = Random.Range(0, area2.Length);
                ingredient.sprite = sprites[b];
                bowl.sprite = bowls;
                soup.sprite = soups;
                break;
            case 3:
                int c = Random.Range(0, area3.Length);
                ingredient.sprite = sprites[c];
                bowl.sprite = bowls;
                soup.sprite = soups;
                break;

        }


    }

}
