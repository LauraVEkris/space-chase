using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

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
