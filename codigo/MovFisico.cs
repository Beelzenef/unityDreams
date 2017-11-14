using UnityEngine;

public class MovFisico : MonoBehaviour {

    public float velocidad = 30F;
    public Rigidbody cuerpoRigido;
    Vector3 fuerzaEmpuje;


    void Start () {
        cuerpoRigido = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {
        fuerzaEmpuje = new Vector3(Input.GetAxis("Horizontal") * velocidad, 0, Input.GetAxis("Vertical") * velocidad);
        cuerpoRigido.AddForce(fuerzaEmpuje);
	}
}
