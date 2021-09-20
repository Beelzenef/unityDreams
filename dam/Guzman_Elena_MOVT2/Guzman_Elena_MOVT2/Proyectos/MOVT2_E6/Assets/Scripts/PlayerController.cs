using UnityEngine;

public class PlayerController : MonoBehaviour {

    float velocidad = 4;
    float fuerzaSalto = 2;

	void Update () {
        // Gestion movimiento y salto
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * velocidad, 0, Input.GetAxis("Vertical") * Time.deltaTime * velocidad);

        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.Translate(Vector3.up * fuerzaSalto);
        }

        // ¿Quieres salir del juego?
        SalirDeJuego();
	}

    void SalirDeJuego()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
