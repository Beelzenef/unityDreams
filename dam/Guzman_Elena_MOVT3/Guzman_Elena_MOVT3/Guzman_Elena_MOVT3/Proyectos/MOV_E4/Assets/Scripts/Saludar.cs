using UnityEngine;
using UnityEngine.UI;

public class Saludar : MonoBehaviour {

    public InputField text_Nombre;
    public InputField text_Apellido;

    public Text textSaludo;

    public void Saludo()
    {
        textSaludo.text = "Bienvenid@, " + text_Nombre.text  + " " + text_Apellido.text;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
