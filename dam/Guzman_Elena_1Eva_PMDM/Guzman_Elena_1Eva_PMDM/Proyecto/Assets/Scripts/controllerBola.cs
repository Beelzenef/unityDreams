using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// Elena Guzmán Blanco
// 05/12/2017
// Examen Unity 1ª Evaluacion
public class controllerBola : MonoBehaviour {

	public Text textoFin;
	public Text marcador;
	public Text contadorTiempo;
	public Rigidbody cuerpoRigido;

	private float velocidad;
	private float fuerzaSalto;

	bool marca1;
	bool marca2;
	bool marca3;
	bool marca4;
	bool marca5;

	float puntos;
	float tiempo;

	float umbralSalto;

	// Inicializando objeto
	void Start()
	{
		puntos = 0;
		tiempo = 40;

		velocidad = 0.9F;

		umbralSalto = 0;

		fuerzaSalto = 5.5F;
		marca1 = true;
		marca2 = true;
		marca3 = true;
		marca4 = true;
		marca5 = true;
	}

	void FixedUpdate()
	{
		// Movimientos de bola corredora
		cuerpoRigido.AddForce(new Vector3 (
			Input.GetAxis("Horizontal") * velocidad, 
			0, 
			Input.GetAxis("Vertical") * velocidad));

		if (Input.GetButton ("Jump") && cuerpoRigido.velocity.y == umbralSalto) {
			cuerpoRigido.AddForce (Vector3.up * fuerzaSalto, ForceMode.Impulse);
		}

		// Control de tiempo
		if (tiempo > 0) {
			pasoTiempo ();
		} else {
			mostrarFinJuego ();
		}
			

	}

	void OnTriggerEnter (Collider c)
	{
		// Cuando entra en la zona prohibida (centro de pista)
		if (c.gameObject.tag == "ZonaNT") {
			mostrarFinJuego ();
		}

		// Marcando puntos con barreras
		if (c.gameObject.tag == "Barrera1" && marca1) {
			marca1 = false;
			aumentarPuntos (0.4F);
		}

		if (c.gameObject.tag == "Barrera2" && marca2) {
			marca2 = false;
			aumentarPuntos (0.6F);
		}

		if (c.gameObject.tag == "Barrera3" && marca3) {
			marca3 = false;
			aumentarPuntos (0.8F);
		}

		if (c.gameObject.tag == "Barrera4" && marca4) {
			marca4 = false;
			aumentarPuntos (1F);
		}

		if (c.gameObject.tag == "Barrera5" && marca5) {
			marca5 = false;
			aumentarPuntos (1.2F);
		}

		// Llegando a la meta, finaliza el juego
		if (c.gameObject.tag == "Meta") {
			mostrarFinJuego ();
		}

	}

	// Aumentando contador de tiempo
	void pasoTiempo()
	{
		tiempo -= Time.deltaTime * 0.9F;
		contadorTiempo.text = "Tiempo restante: " + tiempo.ToString ("00:00");
	}

	// Aumentando puntos cada vez que se pase por encima de una barrera
	void aumentarPuntos(float puntosMarcados)
	{
		puntos += puntosMarcados;
		marcador.text = "Puntos: " + puntos.ToString ();
	}

	// Finalización del juego, destrucción de GO y mensaje por pantalla
	void mostrarFinJuego()
	{
		textoFin.text = "Fin del juego";
		Destroy (gameObject);
	}

}
