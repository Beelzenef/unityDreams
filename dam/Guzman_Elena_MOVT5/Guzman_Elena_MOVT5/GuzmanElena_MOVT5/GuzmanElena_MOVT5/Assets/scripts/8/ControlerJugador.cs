using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControlerJugador : MonoBehaviour
{
    private Rigidbody cuerpoRigido;
    public float velocidad;

    float movHorizontal;
    float movVertical;

    public float puntos;

    int puntosEnDuda;

    public Text marcador;

    Vector3 movimiento;

    objetosColision objetoConColision;
    objetosColision objetoColisionAnterior;

    bool sinPrimeraColision;

    enum objetosColision {
        CuboTipo1, CuboTipo2, EsferaTipo1, EsferaTipo2, None
    }

    void Awake()
    {
        cuerpoRigido = GetComponent<Rigidbody>();

        movHorizontal = 0;
        movVertical = 0;

        puntosEnDuda = 0;

        sinPrimeraColision = true;
    }

    void FixedUpdate()
    {
        movHorizontal = Input.GetAxis("Vertical");
        movVertical = Input.GetAxis("Horizontal");

        movimiento = new Vector3(-movHorizontal, 0, movVertical);

        cuerpoRigido.AddForce(movimiento * velocidad);

        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu_principal");
        }

        if (puntos < 0)
        {
            marcador.text = "¡Fin del juego!";
            velocidad = 0;
        }

        actualizarMarcador();
    }

    void OnTriggerEnter(Collider c)
    {
        if (sinPrimeraColision)
        {
            objetoColisionAnterior = gestionarColision(c);
            sinPrimeraColision = false;
        }

        objetoConColision = gestionarColision(c);

        // Si son del mismo tipo, se resta puntos
        if (objetoConColision == objetoColisionAnterior)
        {
            puntos -= puntosEnDuda;
        }

        // Si alternan, suma la mitad de los puntos
        if (esCubo(objetoConColision) && esEsfera(objetoColisionAnterior) || esEsfera(objetoConColision) && esCubo(objetoColisionAnterior))
        {
            puntos += puntosEnDuda / 2;
            Destroy(c.gameObject);
        }
    }

    private objetosColision gestionarColision(Collider c)
    {
        objetosColision tmp = objetosColision.None;

        if (c.gameObject.tag == "2Puntos")
        {
            tmp = objetosColision.CuboTipo1;
            puntosEnDuda = 2;
        }
        if (c.gameObject.tag == "3Puntos")
        {
            tmp = objetosColision.CuboTipo1;
            puntosEnDuda = 3;
        }
        if (c.gameObject.tag == "4Puntos")
        {
            tmp = objetosColision.EsferaTipo1;
            puntosEnDuda = 4;
        }
        if (c.gameObject.tag == "5Puntos")
        {
            tmp = objetosColision.EsferaTipo2;
            puntosEnDuda = 5;
        }

        return tmp;
    }

    private bool esCubo(objetosColision o)
    {
        return o == objetosColision.CuboTipo1 || o == objetosColision.CuboTipo2;
    }

    private bool esEsfera (objetosColision o)
    {
        return o == objetosColision.EsferaTipo2 || o == objetosColision.EsferaTipo1;
    }

    void actualizarMarcador()
    {
        marcador.text = "Marcador: " + puntos.ToString();
    }
}
