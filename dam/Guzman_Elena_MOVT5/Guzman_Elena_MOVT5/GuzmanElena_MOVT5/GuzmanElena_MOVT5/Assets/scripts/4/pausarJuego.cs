using UnityEngine;
using UnityEngine.SceneManagement;

public class pausarJuego : MonoBehaviour {

    bool juegoEnPausa;

    public float minimo = -5;
    public float maximo = 5;

    float tiempo = 0;

    float tmp;

    public GameObject cubo;

    void Awake()
    {
        juegoEnPausa = false;
    }

    void Update()
    {
        if (!juegoEnPausa)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("menu_principal");
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                juegoEnPausa = true;
            }
            juegoEnCurso();
        }
    }

    void OnGUI()
    {
        if (juegoEnPausa)
            opcionSalir();
    }

    void juegoEnCurso()
    {
        cubo.transform.position = new Vector3(Mathf.Lerp(minimo, maximo, tiempo), 0, 0);

        tiempo += 0.5F * Time.deltaTime;

        if (tiempo > 1.0F)
        {
            ConmutarValores();
        }
    }

    void ConmutarValores()
    {
        tmp = maximo;
        maximo = minimo;
        minimo = tmp;

        tiempo = 0;
    }

    void opcionSalir()
    {
        GUI.Box(new Rect(240, 160, 180, 120), "Menú de juego");
        if (GUI.Button(new Rect(280, 200, 100, 30), "Seguir jugando") == true)
        {
            juegoEnPausa = false;
        }
        if (GUI.Button(new Rect(280, 230, 100, 30), "Salir") == true)
        {
            SceneManager.LoadScene("menu_principal");
        }
    }
}
