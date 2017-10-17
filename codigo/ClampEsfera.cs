using UnityEngine;

public class ClampEsfera : MonoBehaviour {

    public int limMenor = 0;
    public int limMayor = 0;

    public float velocidad = 0;

    float valor = 0;
	
	void Update () {

        // Mover el objeto dentro de los límites
        valor += Input.GetAxis("Horizontal") * (velocidad * Time.deltaTime);
        valor = Mathf.Clamp(valor, limMenor, limMayor);

        transform.position = new Vector3(valor, 0, 0);
	}
}
