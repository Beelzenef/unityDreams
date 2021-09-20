using UnityEngine;

public class movCinematico : MonoBehaviour {

    public int limMenor;
    public int limMayor;

    public float velocidad;

    float valor;

    void Update()
    {
        valor += Input.GetAxis("Horizontal") * (velocidad * Time.deltaTime);
        valor = Mathf.Clamp(valor, limMenor, limMayor);

        transform.position = new Vector3(valor, transform.position.y, transform.position.z);
    }
}
