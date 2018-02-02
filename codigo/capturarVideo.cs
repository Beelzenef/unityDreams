using UnityEngine;

public class capturarVideo : MonoBehaviour {

    // Para capturar vídeo

    string directorioParaGuardar;
    int velocidadFrameRate;

    string nombreCaptura;

    void Start () {
        directorioParaGuardar = "Capturas";
        velocidadFrameRate = 25;

        Time.captureFramerate = velocidadFrameRate;

        System.IO.Directory.CreateDirectory(directorioParaGuardar);
	}
	
	void Update () {
        nombreCaptura = string.Format("{0}/{1:D04}captura.png", directorioParaGuardar, Time.frameCount);

        Application.CaptureScreenshot(nombreCaptura);
	}
}
