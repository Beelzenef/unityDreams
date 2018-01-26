using UnityEngine;

public class estilosGUI : MonoBehaviour {

    public GUIStyle botonCustom;

    void OnGUI()
    {
        cambiarAspecto();
    }

    void cambiarAspecto()
    {
        GUI.Label(new Rect(10, 10, 160, 50), "Soy un label camuflado de un botón", "box");
        GUI.Button(new Rect(50, 60, 50, 50), "Soy un botón camuflado de toggle", "toggle" );
        GUI.Button(new Rect(90, 90, 160, 50), "Soy un control camuflado", botonCustom);
    }

}
