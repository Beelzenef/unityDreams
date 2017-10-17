using UnityEngine;

public class GiroPuerta : MonoBehaviour {

    float velocidad = 3F;

    void Update()
    {

        if (Input.GetAxis("Jump") != 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation,
                                                Quaternion.Euler(0, 90, 0),
                                                Time.deltaTime * velocidad);
        }
    }
}
