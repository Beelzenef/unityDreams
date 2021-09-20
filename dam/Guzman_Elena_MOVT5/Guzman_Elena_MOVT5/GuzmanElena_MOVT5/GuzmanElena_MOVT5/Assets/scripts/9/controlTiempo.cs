using UnityEngine;
using UnityEngine.SceneManagement;

public class controlTiempo : MonoBehaviour
{
    float velocidadRotacion;

    public AudioSource sonidoCorto;

    void Start()
    {
        velocidadRotacion = 2F;
        sonidoCorto = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        transform.Rotate(new Vector3(velocidadRotacion, velocidadRotacion, velocidadRotacion));

        if (Input.GetKeyDown(KeyCode.B))
        {
            sonidoCorto.Play();
        }
    }

    void Update()
    {
        // Cambiando el tiempo del juego, TimeScale a 0 cuando M y a 1 cuando N
        if (Input.GetKeyDown(KeyCode.N))
        {
            Time.timeScale = 1;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            Time.timeScale = 0;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu_principal");
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 30), "TimeScale: " + Time.timeScale.ToString());
        GUI.Label(new Rect(10, 30, 400, 30), "Pulsa M para parar el tiempo, N para reanudarlo");
        GUI.Label(new Rect(10, 50, 200, 30), "Pulsa B para iniciar sonido");
    }

   
}