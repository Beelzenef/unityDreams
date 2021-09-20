using UnityEngine;

public class MovPalas : MonoBehaviour {

    public KeyCode teclaArriba;
    public KeyCode teclaAbajo;

    public float velocidad = 10;

    int pulsarArriba;
    int pulsarAbajo;

    float movimiento = 0;

    int limiteMenor = -12;
    int limiteMayor = 12;

	// Update is called once per frame
	void Update () {

        // ¿Has pulsado hacia abajo?
        if (Input.GetKey(teclaAbajo))
        {
            pulsarAbajo = -1;
        }
        // ¿Has pulsado hacia arriba?
        if (Input.GetKey(teclaArriba))
        {
            pulsarArriba = 1;
        }

        movimiento += (pulsarArriba + pulsarAbajo) * (velocidad * Time.deltaTime);
        movimiento = Mathf.Clamp(movimiento, limiteMenor, limiteMayor);

        transform.position = new Vector3(transform.position.x, transform.position.y, movimiento);

        // ¿Quieres salir del juego?
        SalirDeJuego();

        // Reinicializar las teclas de direccion pulsadas
        teclasACero();
    }

    void teclasACero()
    {
        pulsarAbajo = 0;
        pulsarArriba = 0;
    }

    void SalirDeJuego()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
