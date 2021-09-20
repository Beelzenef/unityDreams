using UnityEngine;
using UnityEngine.SceneManagement;

public class ex2_cambioColorMouseAlea : MonoBehaviour
{

    private Color colorActual;
    private System.Random dado;

    private bool permitirCambio;

    void Start()
    {
        dado = new System.Random();
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
            colorActual = colorAleatorio();
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

    private void cambiarColor(Color c)
    {
        GetComponent<Renderer>().material.color = c;
    }

    private Color colorAleatorio()
    {
        int numero = dado.Next(0, 3);

        Color colorAleatorio = Color.gray;

        switch (numero)
        {
            case 0:
                colorAleatorio = Color.green;
                break;
            case 1:
                colorAleatorio = Color.red;
                break;
            case 2:
                colorAleatorio = Color.blue;
                break;
        }

        return colorAleatorio;
    }

}
