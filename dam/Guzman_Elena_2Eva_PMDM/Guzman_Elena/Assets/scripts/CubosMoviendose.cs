using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubosMoviendose : MonoBehaviour {

	Color colorRojo;
	Vector3 posicionInicial;

	Vector3 primeraPos;
	Vector3 segundaPos;
	Vector3 terceraPos;
	Vector3 cuartaPos;

	void Start () {
		colorRojo = Color.red;
		posicionInicial = gameObject.transform.position;

		primeraPos = new Vector3 (-3F, 1.51F, 0.2F);
		segundaPos = new Vector3 (-3F, 1.51F, -7F);
		terceraPos = new Vector3 (4.28F, 1.51F, -7F);
		cuartaPos = new Vector3 (4.28F, 1.51F, -0.5F);

	}

	void IniciarMovimiento() {
		StartCoroutine ("Movimiento");
	}

	IEnumerator Movimiento () {
		Debug.Log ("Corrutina iniciada");

		while (true) {
			
			gameObject.transform.Translate (primeraPos);

			if (gameObject.transform.position == primeraPos)
				gameObject.transform.Translate (Vector3.Lerp(gameObject.transform.position, segundaPos, 2));

			if (gameObject.transform.position == segundaPos)
				gameObject.transform.Translate (Vector3.Lerp(gameObject.transform.position, terceraPos, 2));

			if (gameObject.transform.position == terceraPos)
					gameObject.transform.Translate (Vector3.Lerp(gameObject.transform.position, cuartaPos, 2));

			if (gameObject.transform.position == cuartaPos) {
					gameObject.transform.Translate (Vector3.Lerp(gameObject.transform.position, posicionInicial, 2));
	
			}

			yield return null;
		}
	}
}
