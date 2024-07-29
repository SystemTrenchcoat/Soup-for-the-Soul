using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip[] musicClips; // Assign this in the inspector
    private AudioSource audioSource;

    void Awake()
    {
        // Add an AudioSource component to the game object if not already present
        audioSource = gameObject.GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        
        // Configure the AudioSource
        audioSource.loop = false; // Do not loop the audio clip
        audioSource.playOnAwake = false; // Do not play audio immediately on awake

        // Optional: Uncomment the following line if you want this object to persist across scenes
        // DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        // Start playing a random music clip at the beginning
        PlayRandomMusic();
    }

    void Update()
    {
        // Continuously check if the music has stopped playing
        if (!audioSource.isPlaying)
        {
            // If music has stopped, play a new random music clip
            PlayRandomMusic();
        }
    }

    // Method to play a random music clip from the array
    void PlayRandomMusic()
    {
        // Ensure there are music clips available to play
        if (musicClips.Length > 0)
        {
            // Select a random music clip from the array
            AudioClip clip = musicClips[Random.Range(0, musicClips.Length)];
            audioSource.clip = clip; // Set the selected clip to the audio source
            audioSource.Play(); // Play the audio clip
        }
        else
        {
            Debug.LogWarning("MusicPlayer: No music clips available to play");
        }
    }
}
