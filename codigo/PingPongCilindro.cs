using UnityEngine;

public class PingPongCilindro : MonoBehaviour {

	void Update () {
        transform.position = new Vector3(Mathf.PingPong(Time.time * 10F, 10F), 0, Mathf.PingPong(Time.time * 10F, 10F));
	}
}
