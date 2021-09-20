using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interfaz : MonoBehaviour {

    float velocidadScroll = 10F;
    TextMesh comp3DText;
    Vector3 posicionTexto;
    Vector3 localVectorUp;

	void Start () {

        comp3DText = gameObject.GetComponent<TextMesh>();
	}
	
	void Update () {
        posicionTexto = transform.position;
        localVectorUp = transform.TransformDirection(0, 1, 0);
        posicionTexto += localVectorUp * velocidadScroll * Time.deltaTime;
        transform.position = posicionTexto;

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
	}

}
