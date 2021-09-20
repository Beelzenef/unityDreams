using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movFisico : MonoBehaviour {

    float fuerzaSalto = 10F;
    float umbralSalto = 0.01F;
    float velocidadMovimiento = 3F;
    public Rigidbody cuerpoRigido;

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void FixedUpdate()
    {
        cuerpoRigido.AddForce(new Vector3(
            Input.GetAxis("Horizontal") * velocidadMovimiento, 0, 0));

        if (Input.GetButtonDown("Jump") && Mathf.Abs(cuerpoRigido.velocity.y) < umbralSalto)
        {
            cuerpoRigido.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
        }
    }
}
