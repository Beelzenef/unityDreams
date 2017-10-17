using UnityEngine;

public class RotarLerpCapsula : MonoBehaviour {

    public Transform desde;
    public Transform hacia;

    public float velocidad = 0.5F;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = Quaternion.Lerp(desde.rotation, hacia.rotation, Time.time * velocidad);
	}
}
