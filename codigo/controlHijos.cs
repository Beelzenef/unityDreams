using UnityEngine;

public class controlHijos : MonoBehaviour {

    public Transform objPadre;

    int i = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            i++;
            GameObject hijo = new GameObject("Hijo_" + i.ToString());
            hijo.transform.parent = objPadre;
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (objPadre.childCount > 0)
            {
                // Eliminando por nombre
                string nombreHijo = objPadre.transform.GetChild(0).name;
                if (objPadre.Find(nombreHijo) != null)
                    Destroy(objPadre.Find(nombreHijo).gameObject);

                // Eliminando por posición
                //Destroy(objPadre.transform.GetChild(0).gameObject);
            }
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            crearObjeto();
        }
    }

    void crearObjeto()
    {
        GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }
}
