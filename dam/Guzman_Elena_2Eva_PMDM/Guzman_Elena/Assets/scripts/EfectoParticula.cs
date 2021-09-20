using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectoParticula : MonoBehaviour {

	ParticleSystem sistemaParts;

	public GameObject gO;
	public GameObject emisor;

	void Start () {
		sistemaParts = gO.GetComponent<ParticleSystem> ();
	}

	void DestruirGO() 
	{
		Debug.Log ("Destruyendo cosas");

		sistemaParts.Play ();
		Destroy (gO, 2);
	}
}
