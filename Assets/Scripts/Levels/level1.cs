using UnityEngine;

public class Level1 : MonoBehaviour
{
    [SerializeField] string[] lines;
    [SerializeField] DialogueManager dialogueManager;
    [SerializeField] private GameManager gameManager;

    //Awake to set physics vars

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();

        dialogueManager.dialogueLines = lines;
        dialogueManager.StartDialogue(0);

        gameManager.level = 1;

    }
}
