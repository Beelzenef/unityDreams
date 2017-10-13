using UnityEngine;

public class MoverAB : MonoBehaviour {

    Vector3 origen;
    public Vector3 destino;
    public float velocidad;
    public GameObject objetoConDestino;

	void Start () {
        //velocidad = 2;
        //destino = new Vector3(14, 0, 0);
	}
	
	void Update () {
        origen = transform.position;
        objetoConDestino.transform.position = Vector3.Lerp(origen, destino, velocidad * Time.deltaTime);
	}
}
