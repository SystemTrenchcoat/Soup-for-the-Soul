using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class DialogueLine
{
    public string characterName;
    public string dialogueText;
    public AudioClip[] soundEffects; // Array of AudioClips for random sound effects
}

public class DialogueManager : MonoBehaviour
{
    public Text nameText; // Assign this in the inspector
    public Text dialogueText; // Assign this in the inspector
    public DialogueLine[] dialogueLines; // Populate this with your dialogue lines in the inspector
    private int currentLine = 0;

    private AudioSource audioSource; // AudioSource to play sound effects

    void Start()
    {
        // Add an AudioSource component if not already present
        audioSource = gameObject.AddComponent<AudioSource>();

        if (dialogueLines.Length > 0)
        {
            DisplayCurrentLine();
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button
        {
            NextLine();
        }
        if (Input.GetMouseButtonDown(1)) // Right mouse button
        {
            PreviousLine();
        }
    }

    void NextLine()
    {
        if (currentLine < dialogueLines.Length - 1)
        {
            currentLine++;
            DisplayCurrentLine();
        }
    }

    void PreviousLine()
    {
        if (currentLine > 0)
        {
            currentLine--;
            DisplayCurrentLine();
        }
    }

    void DisplayCurrentLine()
    {
        nameText.text = dialogueLines[currentLine].characterName;
        dialogueText.text = dialogueLines[currentLine].dialogueText;

        // Play a random sound effect for the current line
        if (dialogueLines[currentLine].soundEffects.Length > 0)
        {
            AudioClip randomClip = dialogueLines[currentLine].soundEffects[Random.Range(0, dialogueLines[currentLine].soundEffects.Length)];
            audioSource.clip = randomClip;
            audioSource.Play();
        }
    }
}