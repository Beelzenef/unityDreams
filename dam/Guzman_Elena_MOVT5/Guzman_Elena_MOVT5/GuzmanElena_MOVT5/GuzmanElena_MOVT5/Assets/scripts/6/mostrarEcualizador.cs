using UnityEngine;
using UnityEngine.SceneManagement;

public class mostrarEcualizador : MonoBehaviour
{
    private int altoEcus = 120;
    private int maximo = 100;
    private int posY = 90;
    private int anchoEcus = 5;

    private float[] valores = { 67F, 89F, 44F, 21F, 45F, 32F, 11F, 34F };

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu_principal");
        }
    }

    void OnGUI()
    {
        GUI.Box(new Rect(120, 50, 350, 200), "Ecualizador");
        valores[0] = GUI.VerticalSlider(new Rect(180, posY, anchoEcus, altoEcus), valores[0], 0, maximo);
        valores[1] = GUI.VerticalSlider(new Rect(210, posY, anchoEcus, altoEcus), valores[1], 0, maximo);
        valores[2] = GUI.VerticalSlider(new Rect(240, posY, anchoEcus, altoEcus), valores[2], 0, maximo);
        valores[3] = GUI.VerticalSlider(new Rect(270, posY, anchoEcus, altoEcus), valores[3], 0, maximo);
        valores[4] = GUI.VerticalSlider(new Rect(300, posY, anchoEcus, altoEcus), valores[4], 0, maximo);
        valores[5] = GUI.VerticalSlider(new Rect(330, posY, anchoEcus, altoEcus), valores[5], 0, maximo);
        valores[6] = GUI.VerticalSlider(new Rect(360, posY, anchoEcus, altoEcus), valores[6], 0, maximo);
        valores[7] = GUI.VerticalSlider(new Rect(390, posY, anchoEcus, altoEcus), valores[7], 0, maximo);
    }
}
