using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    //[SerializeField] allows for private variables to be seen in the inspector, good for inspe
    [SerializeField] private List<Sprite> sprites;
    private List<Sprite> spritesCopy; //This the variable that will be modified
    public SpriteManager instance = new SpriteManager(); //Using the Singleton pattern to make sure there is only one instance of this script


    //Set the copy of the lsit to the original list
    private void Start() {
        spritesCopy = sprites;
    }
    /// <summary>
    /// Select a random sprite from the list, remove it, then return it, so there are no duplicated NPCs.
    /// If the size of the list is less than 3 (the amount of NPCs present)
    /// then set the list equal to the original to continue the loop.
    /// </summary>
    /// <returns>A randomly generated Sprite.</returns>
    public Sprite GenerateSprite() 
    {
        if(spritesCopy.Count < 3) 
        {
            spritesCopy = sprites;
        }
        int i = UnityEngine.Random.Range(0, spritesCopy.Count);
        Sprite generatedSprite = spritesCopy[i];
        spritesCopy.RemoveAt(i);
        Debug.Log("This has ran!");
        return generatedSprite;
        
    }
}
