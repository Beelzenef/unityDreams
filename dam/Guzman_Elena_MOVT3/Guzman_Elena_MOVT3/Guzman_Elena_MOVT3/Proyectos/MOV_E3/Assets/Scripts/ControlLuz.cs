using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLuz : MonoBehaviour {

    GameObject luz;

    bool activo;

	void Start () {

        luz = GameObject.Find("Directional Light");
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
	}

    public void cambiarIntensidad(float v)
    {
        luz.GetComponent<Light>().intensity = v;
    }

    public void interruptorLuz()
    {
        activo = !activo;

        luz.SetActive(activo);
    }

}
