using System.Threading.Tasks;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    DialogueManager dialogueManager;

    //game management
    public bool paused = false;
    public int level = 0;
    public bool finished = false;

    //physics vars

    //gravity keeps the base gravity, not current
    public float gravity = 1.0f;
    public bool firstZoneTouched = false;

    [SerializeField] public string[] finishedLines;

    //checkpoint vars
    public float xPos;
    public float yPos;
    public float zPos;

    private void Start()
    {
        dialogueManager = FindFirstObjectByType<DialogueManager>();
    }

    public void startDialogue(string[] Lines)
    {
        dialogueManager.dialogueLines = Lines;
        dialogueManager.StartDialogue(0);
    }

    public void finishedGame()
    {
        dialogueManager.dialogueLines = finishedLines;
        dialogueManager.StartDialogue(0);
        finished = true;
    }
}
