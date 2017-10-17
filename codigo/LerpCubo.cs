using UnityEngine;

public class LerpCubo : MonoBehaviour {

    public float minimo = -5;
    public float maximo = 5;

    float tiempo = 0;

    float tmp;
	
	void Update () {

        transform.position = new Vector3(Mathf.Lerp(minimo, maximo, tiempo), 0, 0);

        tiempo += 0.5F * Time.deltaTime;

        // ¿Ha llegado a su destino? Revertimos valores
        if (tiempo > 1.0F)
        {
            ConmutarValores();
        }

	}

    void ConmutarValores()
    {
        tmp = maximo;
        maximo = minimo;
        minimo = tmp;

        tiempo = 0;
    }
}
