using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    private float waitIncrease = 0;
    private float donationChance = 0;
    private float popularityIncrease = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void IncreaseWait(float inc)
    {
        if (waitIncrease < inc)
        {
            waitIncrease = inc;
        }
    }

    public void IncreaseDonation(float inc)
    {
        if (donationChance < inc)
        {
            donationChance = inc;
        }
    }

    public void IncreasePopularity(float inc)
    {
        if (popularityIncrease < inc)
        {
            popularityIncrease = inc;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
