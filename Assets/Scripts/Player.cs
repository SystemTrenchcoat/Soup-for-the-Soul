using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Sprite closed;
    private Sprite open;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void FixedUpdate()
    {
        gameObject.transform.position = Vector2.Lerp(transform.position,
            Camera.main.ScreenToWorldPoint(Input.mousePosition),5);

        if (Input.GetMouseButton(0))
        {
            GetComponent<SpriteRenderer>().sprite = closed;
        }

        else
        {
            GetComponent<SpriteRenderer>().sprite = open;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
