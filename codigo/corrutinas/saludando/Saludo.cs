using System.Collections;
using UnityEngine;

public class Saludo : MonoBehaviour {

    bool ejecutar;

	void Start () {
        //StartCoroutine("saludoConsola");
        ejecutar = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StopCoroutine("saludoConsola");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            ejecutar = false;
        }
    }

    IEnumerator saludoConsola()
    {
        while (true) {
            if (!ejecutar)
                yield break;
            Debug.Log("Holi");
            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator saludoConsolaConMsg(string msg, float tiempo)
    {
        while (true)
        {
            Debug.Log(msg);
            yield return new WaitForSeconds(tiempo);
        }
    }

    public void OnEnable()
    {
        //StartCoroutine("saludoConsola");
        StartCoroutine(saludoConsolaConMsg("jeyo", 5));
        StartCoroutine(saludoConsolaConMsg("Necesito café", 0.2F));
        StartCoroutine(saludoConsolaConMsg("SOCORRO", 1));
    }

    public void OnDisable()
    {
        StopAllCoroutines();
    }
}
