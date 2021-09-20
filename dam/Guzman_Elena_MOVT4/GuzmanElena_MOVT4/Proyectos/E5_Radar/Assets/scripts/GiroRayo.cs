using UnityEngine;
using UnityEngine.UI;

public class GiroRayo : MonoBehaviour {

    RaycastHit[] gosImpactados;
    Vector3 direccionRayo;
    int alcanceRayo = 10;

    public Text textoColision;

    void Update()
    {
        direccionRayo = transform.TransformDirection(Vector3.right * (-1) * alcanceRayo);
        gosImpactados = Physics.RaycastAll(transform.position, direccionRayo);

        foreach (RaycastHit item in gosImpactados)
        {
            textoColision.text = "Detectado " + item.collider.ToString();
        }

        Debug.DrawRay(transform.position, direccionRayo, Color.red);

        transform.Rotate(Vector3.up);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
