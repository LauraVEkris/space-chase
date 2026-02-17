using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Rendering.CameraUI;

public class Map : MonoBehaviour
{
    [SerializeField] PauseMenu pause;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickedPlanet(string target)
    {
        if (pause.PauseMenuState) { return; }
        print("clicked planet");
        //scene switcher
        SceneManager.LoadScene(target);
    }
}
