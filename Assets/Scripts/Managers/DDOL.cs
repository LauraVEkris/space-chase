using UnityEngine;
using UnityEngine.SceneManagement;

public class DDOL : MonoBehaviour
{
    [SerializeField] GameObject[] gameObjects = new GameObject[0];
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        GameObject[] ddol = GameObject.FindGameObjectsWithTag("ddol");

        if (ddol.Length > 1)
        {
            foreach (GameObject go in gameObjects)
            {
                Destroy(go);
            }
            Destroy(this.gameObject);
        }
        foreach (GameObject go in gameObjects)
        {
           DontDestroyOnLoad(go);
        }
    }
}
