using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControlFPS : MonoBehaviour
{
    private Rigidbody cuerpoRigido;

    int municion;
    int puntosDeVida;

    public float velocidadMovimiento = 7f;
    public float velocidadGiro = 180f;

    private float inputDesplazamiento;
    private float inputGiro;

    public GameObject enemigo;

    public Text marcador;

    Vector3 movimiento;

    AudioSource sonidoDisparo;
    AudioSource sonidoMuerte;
    AudioSource sonidoHerida;

    public GameObject balaPrefab;
    public GameObject enemigoPrefab;
    public Transform spawnBalas;

    bool muerte = false;

    void Awake()
    {
        cuerpoRigido = GetComponent<Rigidbody>();

        puntosDeVida = 3;
        
        sonidoMuerte = GetComponents<AudioSource>()[1];
        sonidoDisparo = GetComponents<AudioSource>()[0];
        sonidoHerida = GetComponents<AudioSource>()[2];
    }

    private void Update()
    {
        // Resetear juego
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        // Salir a pantalla principal
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu_principal");
        }
    }

    private void FixedUpdate()
    {
        if (!muerte)
        {
            inputDesplazamiento = Input.GetAxis("Vertical");
            inputGiro = Input.GetAxis("Horizontal");

            Movimiento();
            Giro();

            if (Input.GetKeyDown(KeyCode.P) && municion > 0)
            {
                Disparo();
            }

            actualizarMarcador();
        }

        ComprobarMuerte();
    }

    private void ComprobarMuerte()
    {
        if (puntosDeVida == 0)
        {
            marcador.text = "¡Fin del juego! R para recargar o ESC para menú";
            muerte = true;
            Destroy(enemigo); 
            sonidoMuerte.Play();
        }
    }

    private void Movimiento()
    {
        Vector3 movement = transform.forward * inputDesplazamiento * velocidadMovimiento * Time.deltaTime;

        cuerpoRigido.MovePosition(cuerpoRigido.position + movement);
    }

    private void GenerarEnemigos()
    {
        GameObject nuevoEnemigo = (GameObject)Instantiate(enemigoPrefab,
            new Vector3(2, 2, 10), spawnBalas.rotation);
    }

    private void Giro()
    {
        float turn = inputGiro * velocidadGiro * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        cuerpoRigido.MoveRotation(cuerpoRigido.rotation * turnRotation);
    }

    void Disparo()
    {
        GameObject bala = (GameObject)Instantiate(
            balaPrefab,
            spawnBalas.position,
            spawnBalas.rotation);

        sonidoDisparo.Play();

        bala.GetComponent<Rigidbody>().velocity = bala.transform.forward * 10;

        Destroy(bala, 2F);
        municion--;
    }

    void OnTriggerEnter(Collider c)
    {
        // Contacto con enemigo
        if (c.gameObject.tag == "Finish")
        {
            puntosDeVida -= 1;
            sonidoHerida.Play();
        }

        // Recoger munición
        if (c.gameObject.tag == "Ammo")
        {
            municion += 10;
            Destroy(c.gameObject);
        }
    }

    void actualizarMarcador()
    {
        marcador.text = "Municion: " + municion.ToString("00") + " Puntos de vida: " + puntosDeVida.ToString() + " - Dispara con P";
    }

}
