using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Rendering.CameraUI;

public class Map : MonoBehaviour
{
    [SerializeField] PauseMenu pause;

    public void ClickedPlanet(string target)
    {
        if (pause.PauseMenuState) { return; }
        //scene switcher
        SceneManager.LoadScene(target);
    }
}
