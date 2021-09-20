using UnityEngine;

public class Colision : MonoBehaviour {

    public float velocidad = 0.2F;
    public float fuerzaSalto = 20F;
    public Rigidbody cuerpoRigido;
    Vector3 fuerzaEmpuje;

    public float fuerzaTorque = 25F;

    float umbralSalto = 0.01F;

    void Start()
    {
        cuerpoRigido = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

        // Esfera saltando, fuerza de empuje
        fuerzaEmpuje = new Vector3(Input.GetAxis("Horizontal") * velocidad, 0, Input.GetAxis("Vertical") * velocidad);
        cuerpoRigido.AddForce(fuerzaEmpuje);

        //cuerpoRigido.freezeRotation = true;

        // Fuerza de torque
        if (Input.GetKeyDown(KeyCode.T))
        {
            cuerpoRigido.AddTorque(Vector3.up);
        }

    }

    void Update()
    {

        if (Input.GetButtonDown("Jump") && Mathf.Abs(cuerpoRigido.velocity.y) < umbralSalto)
        {
            cuerpoRigido.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Enemigo")
        {
            Debug.Log("Ha colisionado con ... " + c.gameObject.name);
            if (c.relativeVelocity.magnitude > 05F)
            {
                //Destroy(c.gameObject);
                c.gameObject.GetComponent<Renderer>().material.color = Color.red;
                Debug.Log(c.gameObject.name + " ha sido destruido");
            }
        }
    }

    void OnCollisionStay(Collision c)
    {
        if (c.gameObject.tag == "Enemigo")
            Debug.Log("Permanece colisionando con ... " + c.gameObject.name);
    }

    void OnCollisionExit(Collision c)
    {
        if (c.gameObject.tag == "Enemigo")
            Debug.Log("Ha dejado de colisionar con ... " + c.gameObject.name);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemigo")
            Debug.Log("Ha tocado un cubo");

        if (other.gameObject.tag == "Agujero")
            Destroy(gameObject);
    }
}
