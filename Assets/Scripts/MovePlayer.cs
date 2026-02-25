using UnityEngine;
using UnityEngine.InputSystem.XR;

public class MovePlayer : MonoBehaviour
{
    //[SerializeField] float xPosition;
    //[SerializeField] float yPosition;
    //[SerializeField] float zPosition;
    //[SerializeField] GameObject player;
    public Transform respawnPoint;
    //public static MovePlayer Instance;

    //private void Awake()
    //{
    //    Instance = this;
    //}

    public void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            //other.transform.position = respawnPoint.position;
            other.transform.SetPositionAndRotation(new Vector3 (0, 5 ,0), respawnPoint.rotation);
        }
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Respawn"))
    //    {
    //        transform.position = new Vector3(xPosition, yPosition, zPosition);
    //    }
    //}

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.tag == "Player")
    //    {
    //        collision.transform.position = respawnPoint.position;
    //        print("OUCH");
    //    }
    //}

}
