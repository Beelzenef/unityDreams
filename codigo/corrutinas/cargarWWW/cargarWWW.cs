using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class cargarRecurso : MonoBehaviour {

    string url = "http://bssb.be/wp-content/uploads/2015/11/patito_gigante_6.jpg";
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine("Cargar");
        }
	}

    IEnumerator Cargar()
    {
        WWW www = new WWW(url);
        yield return www;
        Texture2D textura = www.texture;
        GetComponent<RawImage>().texture = textura;
    }
}
