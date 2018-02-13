using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEnemigo : MonoBehaviour {

    Texture texturaEnemigo;

	void Start () {
        texturaEnemigo = GetComponent<Texture>();
	}
	
    public void Detectado()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }

    public void NoDetectado()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
