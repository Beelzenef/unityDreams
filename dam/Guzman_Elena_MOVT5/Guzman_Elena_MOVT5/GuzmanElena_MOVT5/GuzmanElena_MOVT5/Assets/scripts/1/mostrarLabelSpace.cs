using UnityEngine;
using UnityEngine.SceneManagement;

public class mostrarLabelSpace : MonoBehaviour {

    bool labelVisible;

    void Start()
    {
        labelVisible = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            labelVisible = !labelVisible;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu_principal");
        }
    }

	void OnGUI()
    {
        if (labelVisible)
        {
            GUI.Label(new Rect(350, 200, 300, 100), "¡Soy un GUI.Label!");
        }
    }

}
