using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButton : MonoBehaviour
{
    public enum type { wait, donation, popularity, hat };
    public type upgrade;
    public float value;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetMouseButton(0))
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                Upgrades player = collision.GetComponent<Upgrades>();

                switch (upgrade)
                {
                    case type.wait:
                        player.IncreaseWait(value);
                        break;
                    case type.donation:
                        player.IncreaseDonation(value);
                        break;
                    case type.popularity:
                        player.IncreasePopularity(value);
                        break;
                }
            }
        }
    }
}
