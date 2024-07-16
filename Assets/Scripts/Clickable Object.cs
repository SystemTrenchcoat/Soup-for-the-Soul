using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    public GameObject player;
    public Soup soup;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
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
            if(Input.GetMouseButtonDown(0))
            {
                switch(tag)
                {
                    case "Bowl":
                        soup.bowl = true;
                        break;
                    case "Broth":
                        soup.broth = true;
                        break;
                    case "Ingredients":
                        if (gameObject == soup.ingredientList[0])
                        {
                            soup.ingredients[0] = true;
                        }
                        if (gameObject == soup.ingredientList[1])
                        {
                            soup.ingredients[1] = true;
                        }
                        if (gameObject == soup.ingredientList[2])
                        {
                            soup.ingredients[2] = true;
                        }
                        if (gameObject == soup.ingredientList[3])
                        {
                            soup.ingredients[3] = true;
                        }
                        break;
                }
            }
        }
    }
}
