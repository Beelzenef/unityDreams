using UnityEngine;

public class MovimientoBola : MonoBehaviour {

    float velocidad = 15F;

    public Rigidbody cuerpoRigido;
    Vector3 fuerzaEmpuje;

    Color colorACambiar;

    System.Random dado;

    void Start()
    {
        cuerpoRigido = GetComponent<Rigidbody>();
        dado = new System.Random();
    }

    void FixedUpdate () {
        fuerzaEmpuje = new Vector3(Input.GetAxis("Horizontal") * velocidad, 0, Input.GetAxis("Vertical") * velocidad);
        cuerpoRigido.AddForce(fuerzaEmpuje);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Application.Quit();
        }
    }

    void OnCollisionEnter(Collision c)
    {
        colorACambiar = colorAleatorio();
        if (c.gameObject.tag == "Cubo")
        {
            c.gameObject.GetComponent<Renderer>().material.color = colorACambiar;
        }

        Debug.Log("Entrando en colisión");
    }

    void OnCollisionExit(Collision c)
    {
        Debug.Log("Saliendo de colisión");
    }

    void OnCollisionStay(Collision c)
    {
        Debug.Log("Colisión en curso");
    }

    Color colorAleatorio()
    {
        int num = dado.Next(1, 4);

        Color colorTMP = Color.white;

        switch (num)
        {
            case 1:
                colorTMP = Color.red;
                break;
            case 2:
                colorTMP = Color.blue;
                break;
            case 3:
                colorTMP = Color.green;
                break;
        }

        return colorTMP;

    }
}
