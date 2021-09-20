using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class volverAMenu : MonoBehaviour {
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			SceneManager.LoadScene ("menu");
		}
	}
}
