using UnityEngine;

public class GravityZone : MonoBehaviour
{
    FirstPersonController controller;
    GameManager gameManager;

    [SerializeField] float tempGrav;

    private void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
        controller = FindFirstObjectByType<FirstPersonController>();
    }

    // “other” refers to the collider on the GameObject inside this trigger
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            controller.UpdateGravity(tempGrav);
        }
        Debug.Log("Entered zone");
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            controller.UpdateGravity(gameManager.gravity);
        }
        Debug.Log("Exited zone");
    }
}
