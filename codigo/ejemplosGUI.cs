using UnityEngine;

public class ejemplosGUI : MonoBehaviour
{
    bool labelVisible;
    string textoIntroducido;
    string textoArea;
    
    void Start()
    {
        labelVisible = false;
        textoIntroducido = string.Empty;
        textoArea = string.Empty;
    }

    public void OnGUI()
    {
        if (labelVisible)
            mostrarLabel(textoIntroducido);
        mostrarBoton();
        //mostrarRepiteBoton();
        //mostrarTextInput();
        mostrarTextArea();
    }

    void mostrarLabel(string texto)
    {
        //string textoMostrar = "wololoooooo";

        int anchoChar = 6;

        float posX = (float)Screen.width / 2 - textoIntroducido.Length * anchoChar / 2;
        float posY = 50;

        float alto = 20;
        float ancho = 300;

        Rect rect = new Rect(posX, posY, ancho, alto);

        GUI.color = Color.red;
        GUI.Label(rect, textoIntroducido);
    }

    void mostrarBoton()
    {
        if (GUI.Button(new Rect(10, 10, 300, 30), "Púlsame"))
        {
            labelVisible = !labelVisible;
        }

        GUI.Button(new Rect(40, 40, 300, 30), new GUIContent("¡También a mí!", "Púlsalo o se siente triste..."));
    }

    void mostrarRepiteBoton()
    {
        if (GUI.RepeatButton(new Rect(100, 100, 300, 30), "Repite"))
            labelVisible = true;
        else
            labelVisible = false;
    }

    void mostrarTextInput()
    {
        textoIntroducido = GUI.TextField(new Rect(150, 150, 300, 30), textoIntroducido);
    }

    void mostrarTextArea()
    {
        textoArea = GUI.TextArea(new Rect(100, 250, 300, 100), textoArea);
    }
}
