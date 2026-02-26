using UnityEngine;
using UnityEngine.InputSystem.XR;

public class Checkpoint : MonoBehaviour
{
    GameManager gameManager;

    private void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            gameManager.xPos = this.transform.position.x;
            gameManager.yPos = this.transform.position.y;
            gameManager.zPos = this.transform.position.z;
        }
    }
}
