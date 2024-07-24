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
<<<<<<< HEAD
    public Sprite bowls;
=======
>>>>>>> 7a5116d (Organized scripts, reopen them all)
    public SpriteRenderer soup;


    void Start()
    {
<<<<<<< HEAD
        GetComponent<Renderer>().enabled = true;
=======
        renderer.enabled = true;
>>>>>>> 7a5116d (Organized scripts, reopen them all)
        MakeCustomer();
    }

    void MakeCustomer()
    {
        int i = Random.Range(0,sprites.Length);
<<<<<<< HEAD
        //GetComponent<Renderer>().sprite = sprites[i];
=======
        renderer.sprite = sprites[i];
>>>>>>> 7a5116d (Organized scripts, reopen them all)
    }

    void GetOrder()
    {
<<<<<<< HEAD
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
=======
       // switch()
>>>>>>> 7a5116d (Organized scripts, reopen them all)


    }

}
