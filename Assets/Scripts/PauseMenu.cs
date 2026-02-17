using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using static UnityEngine.GraphicsBuffer;

public class PauseMenu : MonoBehaviour
{
    InputAction ManagePause;
    public bool PauseMenuState = false;

    [SerializeField] GameObject menu;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ManagePause = InputSystem.actions.FindAction("OpenPause");
        ManagePause.performed += context => ChangePauseMenu();
    }

    public void ChangePauseMenu()
    {
        PauseMenuState = !PauseMenuState;
        menu.SetActive(PauseMenuState);
        if (PauseMenuState)
        {
            Time.timeScale = 0f;
        }
        else { Time.timeScale = 1f; }
    }

    public void StarMap()
    {
        SceneManager.LoadScene("Main");
        ChangePauseMenu();
    }

    public void Quit()
    {
        print("kill app");
        Application.Quit();
    }
}
