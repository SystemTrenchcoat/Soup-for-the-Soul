using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    public Soup soup;

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

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player");
            if (Input.GetMouseButtonDown(0))
            {
                switch (tag)
                {
                    case "Bowl":
                        soup.addBowl();
                        break;
                    case "Broth":
                        soup.addBroth();
                        break;
                    case "Ingredients":
                        if (gameObject == soup.ingredientList[0])
                        {
                            soup.addIngredient(0);
                        }
                        if (gameObject == soup.ingredientList[1])
                        {
                            soup.addIngredient(1);
                        }
                        if (gameObject == soup.ingredientList[2])
                        {
                            soup.addIngredient(2);
                        }
                        if (gameObject == soup.ingredientList[3])
                        {
                            soup.addIngredient(3);
                        }
                        break;
                }
            }
        }
    }
}