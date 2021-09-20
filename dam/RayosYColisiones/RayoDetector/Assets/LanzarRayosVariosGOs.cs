using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzarRayosVariosGOs : MonoBehaviour {

    Vector3 direccionRayo;
    int alcanceRayo = 20;

    RaycastHit[] gosImpactados;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        direccionRayo = transform.TransformDirection(Vector3.right * (-1) * alcanceRayo);
        gosImpactados = Physics.RaycastAll(transform.position, direccionRayo);

        foreach (RaycastHit item in gosImpactados)
        {
            Debug.Log("Detectado: tipo: " + item.GetType().ToString() + " y Collider " + item.collider.ToString());
        }

        Debug.DrawRay(transform.position, direccionRayo, Color.red);
        if (Input.GetKey(KeyCode.Space))
            transform.Rotate(Vector3.up);
    }
}
