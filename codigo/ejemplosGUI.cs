using UnityEngine;

public class ejemplosGUI : MonoBehaviour
{
    Renderer renderer;

    bool labelVisible;
    string textoIntroducido;
    string textoArea;

    public Texture icono;

    public GameObject luz;
    bool activarLuz;

    string[] botonesToolbar;
    int botonActivo;

    int botonActivoGrid;
    int nColumnas;

    public Texture[] texturas;

    float valorActualH;
    float valorActualV;

    // Use this for initialization
    void Start()
    {
        labelVisible = false;
        textoIntroducido = string.Empty;
        textoArea = string.Empty;
        activarLuz = true;

        luz = new GameObject();
        luz = GameObject.Find("Directional Light");

        botonesToolbar = new string[]{ "Opcion 1", "Opción 2", "Opción 3" };
        botonActivo = 0;

        nColumnas = 2;
        nFilas = 2;
        botonActivoGrid = 0;

        valorActualH = 0;
        valorActualV = 0;
    }

    public void OnGUI()
    {
        if (labelVisible)
            mostrarLabel(textoIntroducido);
        mostrarBoton();
        //mostrarRepiteBoton();
        //mostrarTextInput();
        mostrarTextArea();

        // Control de la luz
        activarLuz = GUI.Toggle(new Rect(400, 400, 300, 100), activarLuz, "Encender la luz");
        luz.GetComponent<Light>().enabled = activarLuz;

        // Activando toolbar
        botonActivo = GUI.Toolbar(new Rect(600, 300, 200, 50), botonActivo, botonesToolbar);

        // Activando SelectionGrid
        botonActivoGrid = GUI.SelectionGrid(new Rect(500, 100, 300, 300), botonActivoGrid, texturas, nColumnas);

        // Sliders
        valorActualH = GUI.HorizontalSlider(new Rect(500, 100, 300, 300), valorActualH, 0, 50);
        valorActualV = GUI.VerticalSlider(new Rect(400, 100, 300, 300), valorActualV, 0, 50);
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

        //GUI.Button(new Rect(40, 40, 300, 30), new GUIContent("¡También a mí!", "Púlçsalo o se siente triste..."));
        GUI.Button(new Rect(40, 40, 300, 30), new GUIContent("Botoncito", icono));
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
