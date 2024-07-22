using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorControl : MonoBehaviour
{
    public Texture2D Image1;
    public Texture2D Image2;
    public CursorMode CursorMode = CursorMode.Auto;
    public Vector2 hotspot = Vector2.zero;

    public Soup soup;
   // public static bool GetMouseButtonDown(int button);
    // Start is called before the first frame update
    void Start()
    {
        //Cursor.SetCursor(Image1, hotspot, CursorMode);
        DontDestroyOnLoad(gameObject);

        soup = GameObject.FindGameObjectWithTag("Soup").GetComponent<Soup>();
        GameObject.FindGameObjectWithTag("Soup").SetActive(false);
    }

    

    // Update is called once per frame
    void Update()
    {

        //public static bool GetMouseButtonDown(int button);
        if (Input.GetMouseButton(0))
        {
            Cursor.SetCursor(Image2, hotspot, CursorMode);
            //Debug.Log("Yes");
        }else
        { 
            Cursor.SetCursor(Image1, hotspot, CursorMode);
            //Debug.Log("no");
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        string tg = collision.gameObject.tag;
        Debug.Log(tg);
        if (Input.GetMouseButtonDown(0))
        {
            switch (tg)
            {
                case "Bowl":
                    soup.gameObject.SetActive(true);
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
