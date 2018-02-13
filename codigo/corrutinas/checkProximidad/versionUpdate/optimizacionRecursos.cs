using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optimizacionRecursos : MonoBehaviour {

    public GameObject[] enemigos;

	void Start () {
        enemigos = GameObject.FindGameObjectsWithTag("Enemigos");
	}
	
	void Update () {
        ComprobarProximidadEnemigo();
	}

    void ComprobarProximidadEnemigo()
    {
        float maxDistanciaPermitida = 3F;

        foreach (GameObject item in enemigos)
        {
            if (Vector3.Distance(transform.position, item.transform.position) < maxDistanciaPermitida)
            {
                item.SendMessage("Detectado");
            }
            else
            {
                item.SendMessage("NoDetectado");
            }
        }
    }
}
