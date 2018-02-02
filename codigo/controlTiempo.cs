using UnityEngine;

public class controlTiempo : MonoBehaviour {

    Vector3 posIni;
    Vector3 posActual;

    float posXActual;
    float posYActual;
    float posZActual;

    float velocidad;

    float minimoX;
    float maximoX;
    float minimoZ;
    float maximoZ;

    float velocidadRotacion;

	void Start () {

        velocidad = 0.05F;
        minimoX = -4.5F;
        maximoX = 4.5F;

        minimoZ = -4.5F;
        maximoZ = 4.5F;

        velocidad = 2.5F;

        velocidadRotacion = 2F;
    }

    void Update()
    {
        transform.Rotate(new Vector3(velocidadRotacion, velocidadRotacion, velocidadRotacion));
        moverCubo();
        // Cambiando el tiempo del juego, TimeScale a 0 cuando Q y a 1 cuando A

        if (Input.GetKeyDown(KeyCode.N))
        {
            Time.timeScale = 1;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            Time.timeScale = 0;
        }

    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 30), "TimeScale :" + Time.timeScale.ToString());
    }

    void moverCubo()
    {
        // Moviendo el cubo en X y Z en un área determinada

        // Leyendo la coordenada X

        posXActual = transform.position.x + (Input.GetAxis("Horizontal") * velocidad);
        posActual = new Vector3(Mathf.Clamp(posXActual, minimoX, maximoX), transform.position.y, transform.position.z);

        transform.position = posActual;

        // Leyendo la coordenada Z

        posZActual = transform.position.z + (Input.GetAxis("Vertical") * velocidad);
        posActual = new Vector3(posActual.x, posActual.y, Mathf.Clamp(posZActual, minimoZ, maximoZ));

        transform.position = posActual;
    }
}
