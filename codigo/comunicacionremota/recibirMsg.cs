using UnityEngine;

public class recibirMsg : MonoBehaviour {

    void MostrarMsg()
    {
        Debug.Log("Método invocado");
    }

    void crearGO(GameObject go)
    {
        go.SetActive(true);
        go.transform.localScale *= 2;
        go.AddComponent<Rigidbody>();
    }
}
