using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorControl : MonoBehaviour
{
    public Texture2D Image1;
    public Texture2D Image2;
    public CursorMode CursorMode = CursorMode.Auto;
    public Vector2 hotspot = Vector2.zero;
   // public static bool GetMouseButtonDown(int button);
    // Start is called before the first frame update
    void Start()
    {
        //Cursor.SetCursor(Image1, hotspot, CursorMode);
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
}
