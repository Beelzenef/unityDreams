using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiroSprites : MonoBehaviour {

    public Image img1;
    public Image img2;
    public Image img3;
    public Image img4;

    // Update is called once per frame
    void Update () {

        img1.GetComponent<Transform>().Rotate(4, 0, 0);
        img2.GetComponent<Transform>().Rotate(1, 0, 0);
        img3.GetComponent<Transform>().Rotate(2, 1, 0);
        img4.GetComponent<Transform>().Rotate(0, 1, 0);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
	}
}
