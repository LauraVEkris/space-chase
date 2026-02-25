using UnityEngine;
using UnityEngine.InputSystem.XR;

public class Level1 : MonoBehaviour
{
    [SerializeField] string[] lines;
    [SerializeField] private DialogueManager dialogueManager;
    [SerializeField] private GameManager gameManager;

    //Awake to set physics vars

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
        dialogueManager = FindFirstObjectByType<DialogueManager>();

        dialogueManager.dialogueLines = lines;
        dialogueManager.StartDialogue(0);

        gameManager.level = 1;

    }
}
