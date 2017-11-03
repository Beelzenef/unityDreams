using UnityEngine;

public class AnadirBoton : MonoBehaviour {

    // Boton a colar
    GameObject primerBoton;
    // Contenedor de botones
    GameObject padreDeBotones;

    void Start () {
        primerBoton = GameObject.Find("btnPrimero");
        padreDeBotones = GameObject.Find("Contenido");
    }

    void Update () {
		
	}

    public void AnadirButton()
    {
        // Añado un clon dle boton btnPrimero como hijo de Contenido
        Instantiate(primerBoton, padreDeBotones.GetComponent<Transform>());
    }


}
