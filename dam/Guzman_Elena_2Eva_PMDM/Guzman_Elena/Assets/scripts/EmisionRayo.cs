using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EmisionRayo : MonoBehaviour {

	bool juegoPausado;

	public GameObject emisor;

	Vector3 nuevaDireccion;

	bool cilindrodestruido = false;
	bool cubodestruido = false;

	void Start () {
		juegoPausado = false;
		nuevaDireccion = Vector3.forward;
	}
	
	void Update () {

		if (Input.GetKeyDown(KeyCode.C)) {
				CapturarImgs();
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			juegoPausado = !juegoPausado;	
		}

		if (!juegoPausado) {

			if (emisor.transform.position.x > -4)
				emisor.transform.Translate(new Vector3(-0.05F, 0));
		}
	}

	void FixedUpdate() {

		nuevaDireccion = nuevaDireccion + Vector3.forward;
		
		if (!juegoPausado) {

			Ray rayo = new Ray (emisor.transform.position, nuevaDireccion);

			RaycastHit impacto;

			if (Physics.Raycast(rayo, out impacto)) {
				Debug.Log (impacto.collider.GetType ());
				Debug.DrawRay (emisor.transform.position, nuevaDireccion, Color.red);
				if (!(impacto.collider.tag == "Player")) {

					if (impacto.collider.name == "Cubo") {
						impacto.collider.SendMessage ("DestruirGO");
						cubodestruido = true;
					}

					if (impacto.collider.name == "Capsula") {
						impacto.collider.SendMessage ("DestruirGO");
						cilindrodestruido = true;
					}
				}
			}

			if (cubodestruido && cilindrodestruido) {
				StartCoroutine ("cargarEscena2");
			}
		}
	}

	void CapturarImgs() {
		Debug.Log ("Capturando escenas");

		System.IO.Directory.CreateDirectory ("capturas");

		for (int i = 0; i < 3; i++) {
			Application.CaptureScreenshot ("capturas/captura" + i.ToString ());
		}
	}

	IEnumerator cargarEscena2() {
		yield return new WaitForSeconds (5);
		SceneManager.LoadScene ("escena2");
	}
}
