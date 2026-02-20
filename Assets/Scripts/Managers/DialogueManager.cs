using System.Collections;
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
    bool dialogueActive = false;
    bool timedOut = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //connect action to go to next dialogue
        next = InputSystem.actions.FindAction("Click");
        next.performed += context => EndDialogue();
    }

    public void StartDialogue(int line)
    {
        if (dialogueActive) { return; }
        currentDialogue = Instantiate(dialoguePrefab);
        currentDialogue.GetComponent<DialogueBox>().setText(dialogueLines[line]);
        dialogueActive = true;
        timedOut = true;
        //short timeout for dialogue end
        StartCoroutine(TimeOut());
    }

    IEnumerator TimeOut()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(0.2f);
        timedOut = false;
    }

    public void EndDialogue()
    {
        if (!dialogueActive || timedOut) { return; }
        Destroy(currentDialogue);
        dialogueActive = false;
        //check if there is more dialogue, otherwise reset and move on
        if (dialogueLines.Length-1 > currentLine) 
        {
            currentLine++;
            StartDialogue(currentLine);
        }
        else { currentLine = 0;}
    }
}
