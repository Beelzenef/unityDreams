using UnityEngine;

public class LanzarDados : MonoBehaviour {

    public float fuerzaSalto = 10F;
    private float umbralSalto = 0.01F;
    private int valorAleatorio = 0;

    public Rigidbody cuerpoRigido;
    private Vector3 fuerzaVertical;
    private System.Random dado;

    void Start ()
    {
        dado = new System.Random();
        fuerzaVertical = new Vector3(0.5F, 1, 0);
    }

    void FixedUpdate ()
    {
        if (Input.GetButtonDown("Jump") && Mathf.Abs(cuerpoRigido.velocity.y) < umbralSalto)
        {
            valorAleatorio = dado.Next(5, 20);

            cuerpoRigido.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
            cuerpoRigido.AddTorque(Vector3.one * valorAleatorio);
        }
    }
}
