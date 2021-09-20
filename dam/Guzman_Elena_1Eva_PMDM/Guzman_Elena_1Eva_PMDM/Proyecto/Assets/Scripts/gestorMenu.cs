using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gestorMenu : MonoBehaviour {

	public void Salir()
	{
		Application.Quit ();
	}

	public void Jugar()
	{
		SceneManager.LoadScene ("juego");
	}
}
