using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    public Soup soup;
    public int ingredient;

    public void click()
    {
        Debug.Log(tag);
        switch (tag)
        {
            case "Bowl":
                soup.addBowl();
                break;
            case "Broth":
                soup.addBroth();
                break;
            case "Ingredient":
                soup.addIngredient(ingredient);
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        soup = GameObject.FindGameObjectWithTag("Soup").GetComponent<Soup>();
    }

    private void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //private void OnCollisionStay2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        Debug.Log("Player");
    //        if (Input.GetMouseButtonDown(0))
    //        {
    //            switch (tag)
    //            {
    //                case "Bowl":
    //                    soup.addBowl();
    //                    break;
    //                case "Broth":
    //                    soup.addBroth();
    //                    break;
    //                case "Ingredient":
    //                    soup.addIngredient(ingredient);
    //                    break;
    //            }
    //        }
    //    }
    //}
}