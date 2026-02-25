using UnityEngine;

public class GameManager : MonoBehaviour
{
    DialogueManager dialogueManager;

    //game management
    public bool paused = false;
    public int level = 0;

    //physics vars
    public float gravity = 1.0f;
    public bool firstZoneTouched = false;

    private void Start()
    {
        dialogueManager = FindFirstObjectByType<DialogueManager>();
    }

    public void startDialogue(string[] Lines)
    {
        dialogueManager.dialogueLines = Lines;
        dialogueManager.StartDialogue(0);
    }
}
