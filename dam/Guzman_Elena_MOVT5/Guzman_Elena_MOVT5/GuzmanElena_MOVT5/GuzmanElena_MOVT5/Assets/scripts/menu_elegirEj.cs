using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_elegirEj : MonoBehaviour {

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

	public void ex1()
    {
        SceneManager.LoadScene("ex1");
    }

    public void ex2()
    {
        SceneManager.LoadScene("ex2");
    }

    public void ex3()
    {
        SceneManager.LoadScene("ex3");
    }

    public void ex4()
    {
        SceneManager.LoadScene("ex4");
    }

    public void ex5()
    {
        SceneManager.LoadScene("ex5");
    }

    public void ex6()
    {
        SceneManager.LoadScene("ex6");
    }

    public void ex7()
    {
        SceneManager.LoadScene("ex7");
    }

    public void ex8()
    {
        SceneManager.LoadScene("ex8");
    }

    public void ex9()
    {
        SceneManager.LoadScene("ex9");
    }

    public void ex10()
    {
        SceneManager.LoadScene("ex10");
    }
}
