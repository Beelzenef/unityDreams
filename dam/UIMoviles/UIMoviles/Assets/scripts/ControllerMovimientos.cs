using UnityEngine;

// Asignado al objeto a controlar
public class ControllerMovimientos : MonoBehaviour {

    // Velocidad de desplazamiento en X e Y
    float velocidadMovimiento = 5F;
    // Velocidad de zoom
    float velocidadZoom = 0.05F;

    enum Acciones {
        arriba, abajo, derecha, izquierda, zoomIn, zoomOut, detenido };

    // Booleans para la accion a realizar
    /*
    bool movimientoDerecha = false;
    bool movimientoIzquierda = false;
    bool movimientoArriba = false;
    bool movimientoAbajo = false;
    bool zoomIn = false;
    bool zoomOut = false;
    */

    Acciones accionElegida = Acciones.detenido;
	
	void Update () {

        switch (accionElegida)
        {
            case Acciones.abajo:
                transform.Translate(Vector3.down * Time.deltaTime * velocidadMovimiento);
                break;
            case Acciones.arriba:
                transform.Translate(Vector3.up * Time.deltaTime * velocidadMovimiento);
                break;
            case Acciones.derecha:
                transform.Translate(Vector3.right * Time.deltaTime * velocidadMovimiento);
                break;
            case Acciones.izquierda:
                transform.Translate(Vector3.left * Time.deltaTime * velocidadMovimiento);
                break;
            case Acciones.zoomIn:
                transform.localScale = new Vector3(transform.localScale.x + velocidadZoom,
                                                    transform.localScale.y + velocidadZoom,
                                                    transform.localScale.z + velocidadZoom);
                break;
            case Acciones.zoomOut:
                transform.localScale = new Vector3(transform.localScale.x - velocidadZoom,
                                                    transform.localScale.y - velocidadZoom,
                                                    transform.localScale.z - velocidadZoom);
                break;
            case Acciones.detenido:
                break;
        }
      
    }

    // Metodos propios publicos

    public void MoverDerecha()
    {
        accionElegida = Acciones.derecha;
    }

    public void MoverIzquierda()
    {
        accionElegida = Acciones.izquierda;
    }

    public void MoverArriba()
    {
        accionElegida = Acciones.arriba;
    }

    public void MoverAbajo()
    {
        accionElegida = Acciones.abajo;
    }

    public void ZoomIn()
    {
        accionElegida = Acciones.zoomIn;
    }

    public void ZoomOut()
    {
        accionElegida = Acciones.zoomOut;
    }

    public void Detener()
    {
        accionElegida = Acciones.detenido;
    }
}
