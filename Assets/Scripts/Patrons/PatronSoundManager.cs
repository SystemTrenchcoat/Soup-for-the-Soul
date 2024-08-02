using UnityEngine;

public class PatronSoundManager : MonoBehaviour
{
    public AudioClip[] happySounds; // Array of happy sound effects
    public AudioClip[] upsetSounds; // Array of upset sound effects
    private AudioSource audioSource; // AudioSource to play the sound effects

    void Start()
    {
        // Add an AudioSource component if not already present
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    // Play a random happy sound effect
    public void PlayHappySound()
    {
        if (happySounds.Length > 0)
        {
            AudioClip randomClip = happySounds[Random.Range(0, happySounds.Length)];
            audioSource.clip = randomClip;
            audioSource.Play();
        }
    }

    // Play a random upset sound effect
    public void PlayUpsetSound()
    {
        if (upsetSounds.Length > 0)
        {
            AudioClip randomClip = upsetSounds[Random.Range(0, upsetSounds.Length)];
            audioSource.clip = randomClip;
            audioSource.Play();
        }
    }
}
