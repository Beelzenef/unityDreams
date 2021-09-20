using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControllerJugador : MonoBehaviour {

    float velocidadMovimiento;
    public Rigidbody cuerpoRigido;

    public GameObject puerta1;
    public GameObject puerta2;

    public Text textoVictoria;

    void Start()
    {
        velocidadMovimiento = 3F;
    }

    void FixedUpdate()
    {
        cuerpoRigido.AddForce(new Vector3(
            Input.GetAxis("Horizontal") * velocidadMovimiento, 
            0, Input.GetAxis("Vertical") * velocidadMovimiento));
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Puerta1")
            Destroy(puerta1);

        if (c.gameObject.tag == "Puerta2")
            Destroy(puerta2);

        if (c.gameObject.tag == "Salida")
        {
            textoVictoria.text = "¡Victoria!";
            Destroy(gameObject);
        }

        if (c.gameObject.tag == "Trampa")
        {
            textoVictoria.text = "Has perdido";
            Destroy(gameObject);
        }
    }
}
