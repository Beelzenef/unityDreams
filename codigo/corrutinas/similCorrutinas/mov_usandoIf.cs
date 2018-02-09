using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_usandoIf : MonoBehaviour {

    const int NCUBOS = 3;
    GameObject[] cubos = new GameObject[NCUBOS];
    float destinoCubo = -4F;

    Vector3 velolololocidad = new Vector3(-3.3F, 0, 0);
    Vector3 velolololocidadRotacion = new Vector3(20F, 20F, 20F);

    void Start () {
        localizarCubos();
        StartCoroutine("moverCubosConCorrutinas");
    }
    
    /*
    void Update () {
        moverCubosSinCorrutinas();
    }
    */

    void localizarCubos()
    {
        cubos[0] = GameObject.Find("Cubo1");
        cubos[1] = GameObject.Find("Cubo2");
        cubos[2] = GameObject.Find("Cubo3");
    }

    void moverCubosSinCorrutinas()
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

    IEnumerator moverCubosConCorrutinas()
    {
        foreach (GameObject go in cubos)
        {
            // Desplazamiento
            yield return StartCoroutine("moverCubo", go);

            // Retener tres segundos antes de ejecutar las siguientes instrucciones
            /*
            for (float tiempoBucle = Time.time; Time.time - tiempoBucle > 3;)
                yield return null;
            */

            yield return new WaitForSeconds(3);

            // Cambio de color
            go.GetComponent<MeshRenderer>().material.color = Color.red;

            // Rotación de cubos
            StartCoroutine("rotarCubos", go);
        }
    }

    IEnumerator rotarCubos (GameObject go)
    {
        while (go.GetComponent<Transform>().rotation.eulerAngles.z < 90)
        {
            Vector3 anguloActual = go.transform.rotation.eulerAngles;
            go.GetComponent<Transform>().rotation = Quaternion.Euler(anguloActual + velolololocidadRotacion * Time.deltaTime);
            yield return null;
        }
    }

    IEnumerator moverCubo (GameObject go)
    {
        while (go.GetComponent<Transform>().position.x > destinoCubo)
        {
            go.GetComponent<Transform>().Translate(velolololocidad.x * Time.deltaTime, velolololocidad.y, velolololocidad.z);
            yield return null;
        }
    }
}
