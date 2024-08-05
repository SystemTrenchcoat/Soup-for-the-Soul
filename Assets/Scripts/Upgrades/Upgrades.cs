using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    private float waitIncrease = 0;
    private float donationChance = 0;
    private float popularityIncrease = 0;
    private bool hat = false;

    public float WaitIncrease { get { return waitIncrease; } }
    public float DonationChance { get {  return donationChance; } }
    public float PopularityIncrease { get { return popularityIncrease; } }
    public bool Hat { get {  return hat; } }

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void IncreaseWait(float inc)
    {
        waitIncrease += inc;
    }

    public void IncreaseDonation(float inc)
    {
        donationChance += inc;
    }

    public void IncreasePopularity(float inc)
    {
        popularityIncrease += inc;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
