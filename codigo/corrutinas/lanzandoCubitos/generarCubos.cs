using System.Collections;
using UnityEngine;

public class generarCubos : MonoBehaviour {

    public GameObject cubo;
    public float ratioTiempoLanzamiento = 0.5F;

	void Start () {
        StartCoroutine(lanzarCubo());
	}

    IEnumerator lanzarCubo()
    {
        yield return new WaitForSeconds(5);

        while (true)
        {
            Instantiate(cubo, transform.position, Random.rotation);
            yield return new WaitForSeconds(ratioTiempoLanzamiento);
        }
    }
}
