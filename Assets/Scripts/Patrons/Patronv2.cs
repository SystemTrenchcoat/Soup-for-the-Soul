using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patronv2 : MonoBehaviour
{
    // List of happy and upset sound effects
    public List<AudioClip> happySounds;
    public List<AudioClip> upsetSounds;

    // Time threshold for patrons waiting too long (in seconds)
    public float waitingThreshold = 30f; // 30 seconds

    // Reference to the AudioSource component for playing sound effects
    private AudioSource audioSource;

    // Timer to track how long the patron has been waiting
    private float waitTimer;

    // Reference to the Patron script
    private Patron patronScript;

    private void Start()
    {
        // Ensure the AudioSource component is attached to the Patron GameObject
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("AudioSource component not found. Make sure the Patron GameObject has an AudioSource component.");
            return;
        }

        // Initialize the wait timer
        waitTimer = 0f;

        // Get the Patron script
        patronScript = GetComponent<Patron>();
        if (patronScript == null)
        {
            Debug.LogError("Patron script not found. Make sure the Patron GameObject has a Patron script.");
        }
    }

    private void Update()
    {
        // Increment the wait timer
        waitTimer += Time.deltaTime;

        // Check if the patron has been waiting too long
        if (waitTimer >= waitingThreshold)
        {
            PlayUpsetSound();
            patronScript.GeneratePatron(); // Generate a new patron
            waitTimer = 0f; // Reset the wait timer
        }
    }

    // This method should be called when the patron is served
    public void ServePatron()
    {
        double score = patronScript.CheckOrder();
        if (score > 0)
        {
            PlayHappySound();
        }
        else
        {
            PlayUpsetSound();
        }

        // Generate a new patron
        patronScript.GeneratePatron();
        waitTimer = 0f; // Reset the wait timer
    }

    // Play a random happy sound effect from the list
    private void PlayHappySound()
    {
        if (happySounds.Count > 0)
        {
            int randomIndex = Random.Range(0, happySounds.Count);
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
            int randomIndex = Random.Range(0, upsetSounds.Count);
            audioSource.clip = upsetSounds[randomIndex];
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("No upset sounds available in the list.");
        }
    }
}
