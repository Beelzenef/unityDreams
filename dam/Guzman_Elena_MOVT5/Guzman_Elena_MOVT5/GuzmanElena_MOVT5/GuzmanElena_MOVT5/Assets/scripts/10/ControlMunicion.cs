using UnityEngine;

public class ControlMunicion : MonoBehaviour {

    Rigidbody cuerpoRigido;

    void Start()
    {
        cuerpoRigido = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Finish")
        {
            Destroy(cuerpoRigido.gameObject);
        }
    }
}
