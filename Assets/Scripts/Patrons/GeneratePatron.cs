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
    public SpriteRenderer soup;


    void Start()
    {
        GetComponent<Renderer>().enabled = true;
        MakeCustomer();
    }

    void MakeCustomer()
    {
        int i = Random.Range(0,sprites.Length);
        //GetComponent<Renderer>().sprite = sprites[i];
    }

    void GetOrder()
    {
       // switch()


    }

}
