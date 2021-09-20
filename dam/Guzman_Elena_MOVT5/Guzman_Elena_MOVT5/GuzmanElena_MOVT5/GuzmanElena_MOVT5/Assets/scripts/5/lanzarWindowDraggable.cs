using UnityEngine;
using UnityEngine.SceneManagement;

public class lanzarWindowDraggable : MonoBehaviour
{

    private Rect sizeVentana = new Rect(15, 15, 200, 150);

    void OnGUI()
    {
        sizeVentana = GUI.Window(0, sizeVentana, moverVentana, "Opciones");
    }

    private void moverVentana(int id)
    {
        GUI.Button(new Rect(sizeVentana.width * 0.5f - 60, sizeVentana.width * 0.5f - 25, 100, 50),
            "Nueva partida");
        GUI.Toggle(new Rect(sizeVentana.width * 0.5f - 90, sizeVentana.width * 0.5f - 60, 200, 20),
            false, "Activar/desactivar sonido");

        GUI.DragWindow();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu_principal");
        }
    }
}
