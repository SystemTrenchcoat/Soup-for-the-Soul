using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class DialogueLine
{
    public string characterName;
    public string dialogueText;
}

public class DialogueManager : MonoBehaviour
{
    public Text nameText; // Assign this in the inspector
    public Text dialogueText; // Assign this in the inspector
    public DialogueLine[] dialogueLines; // Populate this with your dialogue lines in the inspector
    private int currentLine = 0;

    void Start()
    {
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
    }
}
