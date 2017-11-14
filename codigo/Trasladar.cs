using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trasladar : MonoBehaviour {

    public Transform origen;
    public Transform direccion;

    float velocidad = 0.01F;

	void Update () {
        origen.Translate(direccion.transform.position * velocidad);
	}
}
