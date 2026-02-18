using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class DialogueManager : MonoBehaviour
{
    InputAction next;

    //Dialogue vars
    [SerializeField] GameObject dialoguePrefab;
    GameObject currentDialogue;
    public string[] dialogueLines = null;
    int currentLine = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //connect action to go to next dialogue
        next = InputSystem.actions.FindAction("Click");
        next.performed += context => EndDialogue();
    }

    public void StartDialogue(int line)
    {
        currentDialogue = Instantiate(dialoguePrefab);
        currentDialogue.GetComponent<DialogueBox>().setText(dialogueLines[line]);
        currentLine = 1;
    }

    public void EndDialogue()
    {
        Destroy(currentDialogue);
        //check if there is more dialogue, otherwise reset and move on
        if (dialogueLines.Length-1 > currentLine) 
        {
            currentLine++;
            StartDialogue(currentLine);
        }
        else { currentLine = 0; }
    }
}
