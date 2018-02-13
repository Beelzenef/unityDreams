using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class cargarRecurso : MonoBehaviour {

    string url = "http://bssb.be/wp-content/uploads/2015/11/patito_gigante_6.jpg";

    public Image imagen;
    
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine("cargarUIImage");
        }
    }

    IEnumerator cargarUIImage()
    {
        WWW www = new WWW(url);
        yield return www;
        Sprite sprite = TexturaASprite(www.texture);
        GameObject.Find("Image").GetComponent<Image>().sprite = sprite;
    }

    Sprite TexturaASprite(Texture2D textura)
    {
        Rect rect = new Rect(0, 0, textura.width, textura.height);
        Vector2 pivot = new Vector2(0.5F, 0.5F);
        Sprite sprite = Sprite.Create(textura, rect, pivot);
        return sprite;
    }
}
