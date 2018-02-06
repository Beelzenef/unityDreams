using UnityEngine;

public class enviarMsg : MonoBehaviour {

	void Update () {
		// Lanzar msg

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //GameObject.FindGameObjectWithTag("ObjetoReceptor").SendMessage("MostrarMsg", 1, SendMessageOptions.DontRequireReceiver);

            GameObject.FindGameObjectWithTag("ObjetoReceptor").SendMessage("crearGO", GameObject.CreatePrimitive(PrimitiveType.Cube),
                SendMessageOptions.DontRequireReceiver);
        }
	}
}
