using UnityEngine;
// Otros NS
using UnityEngine.SceneManagement;

public class ControlEscenas : MonoBehaviour {
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();	
	}

    public void AEscena1()
    {
        SceneManager.LoadScene("escena1");
    }

    public void AEscena2()
    {
        SceneManager.LoadScene("escena2");
    }

    public void AEscena3()
    {
        SceneManager.LoadScene("escena3");
    }

    public void AEscena4()
    {
        SceneManager.LoadScene("escena4");
    }
}
