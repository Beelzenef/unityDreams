using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCorrutinas : MonoBehaviour {

	float cuentaAtras;
	Color colorRojo;
	public GameObject cubo1;
	public GameObject cubo2;
	public GameObject cubo3;
	bool coNoIniciada;
	bool iniciarCuentaAtras;

	void Start () {

		cuentaAtras = 3;
		colorRojo = Color.red;
		coNoIniciada = true;

		iniciarCuentaAtras = false;
	}

	void Update() {

		if (iniciarCuentaAtras) {
			cuentaAtras -= Time.deltaTime;
			Debug.Log ("Contando");
			if (cuentaAtras <= 0 && coNoIniciada) {

				Debug.Log ("Iniciar corrutina");
				StartCoroutine ("MoverCubos");
				coNoIniciada = false;
			}
		}

		if (Input.GetKeyDown (KeyCode.Escape))
			Application.Quit ();

	}

	void IniciarMovimientoCubos() {

		iniciarCuentaAtras = true;
	}

	IEnumerator MoverCubos() {

		Debug.Log ("Mover cubos");

		cubo1.SendMessage ("IniciarMovimiento");
		yield return new WaitForSeconds (1);
		cubo2.SendMessage ("IniciarMovimiento");
		yield return new WaitForSeconds (1);
		cubo3.SendMessage ("IniciarMovimiento");

		yield break;
	}

	void OnGUI() {
		if (GUI.Button (new Rect (10, 10, 100, 20), "Iniciar")) {
			IniciarMovimientoCubos ();
		}

		GUI.Label (new Rect (30, 30, 100, 20), cuentaAtras.ToString ("0"));
	}
}
