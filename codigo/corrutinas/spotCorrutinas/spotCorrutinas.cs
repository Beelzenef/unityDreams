using System.Collections;
using UnityEngine;

public class controlSpot : MonoBehaviour {

    public Light luz;

    // Métodos públicos

    public void IniParpadeo()
    {
        StartCoroutine("controlParpadeo");
    }
    
    public void StopParpadeo()
    {
        StopCoroutine("controlParpadeo");
    }

    public void IniColor()
    {
        StartCoroutine("controlColor");
    }

    public void StopColor()
    {
        StopCoroutine("controlColor");
    }

    // Corrutinas

    IEnumerator controlParpadeo()
    {
        int nVeces = 20;

        while (true)
        {
            for (int i = 0; i < nVeces; i++)
            {
                luz.enabled = !luz.enabled;
                yield return new WaitForSeconds(Random.Range(0.1F, 0.5F));
            }

            luz.enabled = Random.Range(0, 2) == 0 ? true : false;
            yield return new WaitForSeconds(3);
        }

        
    }

    IEnumerator controlColor ()
    {

        while (true)
        {
            luz.color = Color.Lerp(Color.blue, Color.red, Mathf.PingPong(Time.time / 2, 1));
            yield return null;
        }
    }
}
