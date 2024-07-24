using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorControl : MonoBehaviour
{
    public Texture2D Image1;
    public Texture2D Image2;
    public CursorMode CursorMode = CursorMode.Auto;
    public Vector2 hotspot = Vector2.zero;

    //public Soup soup = null;
    //public static bool GetMouseButtonDown(int button);
    // Start is called before the first frame update
    void Start()
    {
        //Cursor.SetCursor(Image1, hotspot, CursorMode);
        DontDestroyOnLoad(gameObject);

        //if (soup != null)
        //    soup = GameObject.FindGameObjectWithTag("Soup").GetComponent<Soup>();
        //GameObject.FindGameObjectWithTag("Soup").SetActive(false);
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

        transform.localPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    //private void OnCollisionStay2D(Collision2D collision)
    //{
    //    string tg = collision.gameObject.tag;
    //    Debug.Log(collision.gameObject.name);
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        switch (tg)
    //        {
    //            case "Bowl":
    //                soup.gameObject.SetActive(true);
    //                soup.addBowl();
    //                break;
    //            case "Broth":
    //                soup.addBroth();
    //                break;
    //            case "Ingredient":
    //                soup.addIngredient(collision.gameObject.GetComponent<ClickableObject>().ingredient);
    //                break;
    //        }
    //    }
    //}
}
