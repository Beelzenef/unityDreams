using UnityEngine;
using UnityEngine.SceneManagement;

public class destroyBola : MonoBehaviour {

    void OnTriggerEnter(Collider c)
    {
        Destroy(c.gameObject);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
