using UnityEngine;

public class controlJuego : MonoBehaviour {

    float velocidadRotacion = 4.5F;
    Vector3 anguloRotacion = new Vector3(0.33F, 0.33F, 0.33F);
    float fuerzaImpulso;

	void Start () {
        fuerzaImpulso = 10F;
        GetComponent<Rigidbody>().AddForce(Vector3.up * fuerzaImpulso, ForceMode.Impulse);
	}
	
	void Update () {
        transform.Rotate(anguloRotacion * velocidadRotacion);
	}
}
