using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//----------------
using UnityEngine.UI;

public class ControladorDeEventos : MonoBehaviour {

	GameObject _intLuz;
	GameObject _luz;

	// Use this for initialization
	void Start () {
		_intLuz = GameObject.FindWithTag ("intLuz");
		_luz = GameObject.Find ("Directional_Light");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void InterruptorLuz(){
		_luz.SetActive (_intLuz.GetComponent<Toggle> ().isOn);
	}
}
