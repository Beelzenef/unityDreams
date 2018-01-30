using UnityEngine;

public class ControlRayo : MonoBehaviour {

    // Pasando la máscara para la capa número 8
    int mascaraCapa = 1 << 8;

    // También podemos pasar 256 en decimal	(1 0000 0000)

	void FixedUpdate () {

        // Pasando la máscara para la capa número 8
        int mascaraCapa = 1 << 8;

        // También podemos pasar 256 en decimal	
        
        // Revertir la capa
        //mascaraCapa = ~mascaraCapa;

        // El rayo intersecta a cualquier objeto delante de él
        RaycastHit hit;

        // Punto de partida
        Vector3 origen = transform.position;

        // Direccion, en eje Z
        Vector3 direccion = Vector3.forward;

        // Alcance del rayo
        float distancia = Mathf.Infinity;

        // Devuelve true si se produce un impacto
        //if (Physics.Raycast(origen, direccion, distancia))
        if (Physics.Raycast(origen, transform.TransformDirection(direccion), out hit, distancia, mascaraCapa))
        {
            Debug.Log("¡Enemigo impactado!");
            Debug.DrawRay(origen, transform.TransformDirection(direccion) * hit.distance, Color.red);
        }
        else
        {
            Debug.Log("Cualquier cosa que no sea enemigo...");
            Debug.DrawRay(origen, transform.TransformDirection(direccion), Color.blue);
        }
	}
}
