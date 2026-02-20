using UnityEngine;

public class level1 : MonoBehaviour
{
    [SerializeField] string[] lines;
    [SerializeField] DialogueManager dialogueManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialogueManager.dialogueLines = lines;
        dialogueManager.StartDialogue(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
