using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using static UnityEngine.GraphicsBuffer;

public class PauseMenu : MonoBehaviour
{
    InputAction ManagePause;
    public bool PauseMenuState = false;

    [SerializeField] GameObject menu;
    GameManager gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
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
            gameManager.paused = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else {
            Time.timeScale = 1f;
            gameManager.paused = false;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    public void StarMap()
    {
        SceneManager.LoadScene("Main");
        ChangePauseMenu();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Quit()
    {
        print("kill app");
        Application.Quit();
    }
}
