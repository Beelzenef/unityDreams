using UnityEngine;
using UnityEngine.SceneManagement;

public class ex2_cambioColorMouse : MonoBehaviour {

    private Color colorActual;
    private bool permitirCambio;

    void Start () {
        permitirCambio = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu_principal");
        }
    }

    public void OnMouseOver()
    {
        if (permitirCambio)
        {
            colorActual = Color.red;
            cambiarColor(colorActual);
        }
    }

    public void OnMouseExit()
    {
        if (permitirCambio)
            cambiarColor(Color.gray);
    }

    public void OnMouseDown()
    {
        if (permitirCambio)
            cambiarColor(colorActual);
        permitirCambio = false;
    }

    private void cambiarColor (Color c)
    {
        GetComponent<Renderer>().material.color = c;
    }

}
