using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patron : MonoBehaviour
{
    public float timer = 15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
            AcceptOrder();
        }

        timer -= Time.deltaTime;
    }

    public void Appear()
    {

    }

    public void Spawn()
    {

    }

    public void GiveOrder()
    {

    }

    public int AcceptOrder()
    {
        int score = 0;



        return score;
    }
}
