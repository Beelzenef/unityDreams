using UnityEngine;
using UnityEngine.SceneManagement;

public class mostrarMenu : MonoBehaviour {

    string nombre = "Sin nombre";
    string apellidos = "Sin apellidos";
    string edad = "0";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu_principal");
        }
    }

	void OnGUI()
    {
        GUI.Box(new Rect(120, 50, 300, 200), "Datos del usuario");
        GUI.Label(new Rect(180, 90, 80, 20), "Nombre");
        nombre = GUI.TextArea(new Rect(250, 90, 80, 20), nombre, 100);
        GUI.Label(new Rect(180, 110, 80, 20), "Apellidos");
        apellidos = GUI.TextArea(new Rect(250, 110, 80, 20), apellidos, 100);
        GUI.Label(new Rect(180, 130, 80, 20), "Edad");
        edad = GUI.TextArea(new Rect(250, 130, 80, 20), edad, 2);

        if (GUI.Button(new Rect(220, 170, 100, 20), "Enviar") == true)
        {
            GUI.Label(new Rect(220, 210, 80, 20), "¡Datos enviados!");
        }
        if (GUI.Button(new Rect(220, 190, 100, 20), "Limpiar") == true)
        {
            nombre = string.Empty;
            edad = string.Empty;
            apellidos = string.Empty;
        }
    }
}
