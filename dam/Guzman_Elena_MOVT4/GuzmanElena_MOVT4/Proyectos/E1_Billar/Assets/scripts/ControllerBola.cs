using UnityEngine;
using UnityEngine.UI;

public class ControllerBola : MonoBehaviour {

    float velocidadMovimiento;

    public Rigidbody cuerpoRigido;
    public Slider valorGiro;

    void Start()
    {
        velocidadMovimiento = 15F;
    }

    void FixedUpdate()
    {
        if (cuerpoRigido.velocity.x == 0 && cuerpoRigido.velocity.z == 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                cuerpoRigido.AddForce(Vector3.forward * velocidadMovimiento, ForceMode.Impulse);
                cuerpoRigido.AddTorque(new Vector3(0, valorGiro.value, 0));

            }
        }
    }
}
