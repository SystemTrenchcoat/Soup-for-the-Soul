using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patronv2 : MonoBehaviour
{
    // List of happy sound effects
    public List<AudioClip> happySounds;

    // List of upset sound effects
    public List<AudioClip> upsetSounds;

    // Time threshold for patrons waiting too long (in seconds)
    public float waitingThreshold = 120f; // 2 minutes

    // Reference to the AudioSource component for playing sound effects
    private AudioSource audioSource;

    // Timer to track how long the patron has been waiting
    private float waitTimer;

    // Flag to check if the patron has been served
    private bool isServed;

    private void Start()
    {
        // Ensure the AudioSource component is attached to the Patron GameObject
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("AudioSource component not found. Make sure the Patron GameObject has an AudioSource component.");
            return;
        }

        // Initialize the wait timer and isServed flag
        waitTimer = 0f;
        isServed = false;
    }

    private void Update()
    {
        // Increment the wait timer if the patron hasn't been served
        if (!isServed)
        {
            waitTimer += Time.deltaTime;

            // Check if the patron has been waiting too long
            if (waitTimer >= waitingThreshold)
            {
                PlayUpsetSound();
                isServed = true; // Mark as served to stop further updates
            }
        }
    }

    // Call this method when the patron is served the soup
    public void ServePatron(bool isCorrectSoup)
    {
        // If the patron hasn't been served yet
        if (!isServed)
        {
            // Play the appropriate sound based on whether the soup is correct
            if (isCorrectSoup)
            {
                PlayHappySound();
            }
            else
            {
                PlayUpsetSound();
            }

            isServed = true; // Mark as served
        }
    }

    // Play a random happy sound effect from the list
    private void PlayHappySound()
    {
        if (happySounds.Count > 0)
        {
            int randomIndex = Random.Range(0, happySounds.Count); // Pick a random sound
            audioSource.clip = happySounds[randomIndex];
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("No happy sounds available in the list.");
        }
    }

    // Play a random upset sound effect from the list
    private void PlayUpsetSound()
    {
        if (upsetSounds.Count > 0)
        {
            int randomIndex = Random.Range(0, upsetSounds.Count); // Pick a random sound
            audioSource.clip = upsetSounds[randomIndex];
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("No upset sounds available in the list.");
        }
    }
}
