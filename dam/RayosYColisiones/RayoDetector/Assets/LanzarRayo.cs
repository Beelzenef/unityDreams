using UnityEngine;

public class LanzarRayo : MonoBehaviour {

    Vector3 forward;
    int alcenceRayo = 10;
	
	void Update () {

        forward = transform.TransformDirection(Vector3.right * (-1) * alcenceRayo);

		if (Physics.Raycast(transform.position, forward))
        {
            Debug.Log("Detectado...");
        }

        Debug.DrawRay(transform.position, forward, Color.red);
        if (Input.GetKey(KeyCode.Space))
            transform.Rotate(Vector3.up);
	}
}
