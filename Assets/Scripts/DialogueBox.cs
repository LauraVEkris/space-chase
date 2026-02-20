using TMPro;
using UnityEngine;

public class DialogueBox : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textbox;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void setText(string text)
    {
        textbox.text = text;
    }
}
