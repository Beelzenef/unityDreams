using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_usandoIf : MonoBehaviour {

    const int NCUBOS = 3;
    GameObject[] cubos = new GameObject[NCUBOS];
    float destinoCubo = -4F;

    Vector3 velolololocidad = new Vector3(-3.3F, 0, 0);

	// Use this for initialization
	void Start () {
        localizarCubos();
	}
	
	// Update is called once per frame
	void Update () {
        moverCubos();
	}

    void localizarCubos()
    {
        cubos[0] = GameObject.Find("Cubo1");
        cubos[1] = GameObject.Find("Cubo2");
        cubos[2] = GameObject.Find("Cubo3");
    }

    void moverCubos()
    {
        // Desplaza cada cubo hasta el final de su recorrido
        if (cubos[0].GetComponent<Transform>().position.x > destinoCubo)
        {
            cubos[0].GetComponent<Transform>().Translate(velolololocidad.x * Time.deltaTime,
                velolololocidad.y, velolololocidad.z);
        }
        else if (cubos[1].GetComponent<Transform>().position.x > destinoCubo)
        {
            cubos[1].GetComponent<Transform>().Translate(velolololocidad.x * Time.deltaTime,
                velolololocidad.y, velolololocidad.z);
        }
        else if (cubos[2].GetComponent<Transform>().position.x > destinoCubo)
        {
            cubos[2].GetComponent<Transform>().Translate(velolololocidad.x * Time.deltaTime,
                velolololocidad.y, velolololocidad.z);
        }
    }
}
