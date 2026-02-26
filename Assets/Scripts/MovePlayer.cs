using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] FirstPersonController controller;
    [SerializeField] GameManager gameManager;
    public GameObject respawnPoint;

    private void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();

        gameManager.xPos = respawnPoint.transform.position.x;
        gameManager.yPos = respawnPoint.transform.position.y;
        gameManager.zPos = respawnPoint.transform.position.z;
    }

    public void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            Vector3 newPos = new Vector3(gameManager.xPos, gameManager.yPos, gameManager.zPos);

            controller.dead = true;
            player.transform.position = newPos;
            StartCoroutine(Revive());
        }
    }

    IEnumerator Revive()
    {
        //yield on a new YieldInstruction that waits for set amount of seconds.
        yield return new WaitForSeconds(0.2f);
        controller.dead = false;
    }
}
