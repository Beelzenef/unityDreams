using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour {

    public float velocidad;
    float movHorizontal;
    float movVertical;

    Rigidbody cuerpoRigido;
    Vector3 movimiento;

	// Use this for initialization
	void Start () {
        cuerpoRigido = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        movHorizontal = Input.GetAxis("Horizontal");
        movVertical = Input.GetAxis("Vertical");

        movimiento = new Vector3(movHorizontal, 0, movVertical);

        cuerpoRigido.AddForce(movimiento * velocidad);
    }
}
