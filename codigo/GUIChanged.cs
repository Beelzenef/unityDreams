using UnityEngine;

public class GUIChanged : MonoBehaviour {

    int botonClickado = 0;
    string[] listaBotones = { "B1", "B2", "B3" };

    string contenido = "MODIFICAME";

    void OnGUI()
    {
        //mostrarBotones();

        mostrarTextbox();
    }

    void mostrarTextbox()
    {
        contenido = GUI.TextField(new Rect(10, 10, 120, 75), contenido);

        if (GUI.changed)
        {
            Debug.Log("Contenido modificado");
        }
    }

    void mostrarBotones()
    {
        botonClickado = GUI.Toolbar(new Rect(10, 10, 120, 75), botonClickado, listaBotones);

        if (GUI.changed)
        {
            Debug.Log("Has pulsado un botón");

            switch (botonClickado)
            {
                case 0:
                    Debug.Log("Has pulsado el botón 1");
                    break;
                case 1:
                    Debug.Log("¡Botón 2!");
                    break;
                case 2:
                    Debug.Log("Tercerito");
                    break;
            }
        }
    }
}
