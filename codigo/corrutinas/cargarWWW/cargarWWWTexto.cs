using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class cargarRecurso : MonoBehaviour {

    string urlTexto = "http://www.ascii-art.de/ascii/def/ducks.txt";

    public Image imagen;
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine("cargarTexto");
        }
	}

    IEnumerator cargarTexto()
    {
        Text textoUI = GameObject.Find("Text").GetComponent<Text>();
        textoUI.text = "Cargando el fichero";
        WWW www = new WWW(urlTexto);
        yield return www;
        string contenido = www.text;
        textoUI.text = contenido;
    }
}
