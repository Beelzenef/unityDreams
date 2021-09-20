using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Otros NS
using UnityEngine.SceneManagement;

public class SalidaEscenas : MonoBehaviour {

	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("main");
    }
}
