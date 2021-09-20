using UnityEngine;

public class ControllerBola : MonoBehaviour {

    float velocidadMovimiento;
    public Rigidbody cuerpoRigido;

    bool permitirMovimiento;

    void Start()
    {
        velocidadMovimiento = 15F;
        permitirMovimiento = true;
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (permitirMovimiento)
            {
                cuerpoRigido.AddForce(Vector3.forward * velocidadMovimiento, ForceMode.Impulse);
                permitirMovimiento = false;
            }
        }
    }
}
