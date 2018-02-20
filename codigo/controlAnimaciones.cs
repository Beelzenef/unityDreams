using UnityEngine;

public class ControladorAnim : MonoBehaviour {

    public Animator _animator;

	void Start () {
        _animator = GetComponent<Animator>();
	}

	void Update () {
        saltar();
        avanzar();
        activarViento();
        rotar();	
	}

    private void saltar()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetTrigger("saltar");
        }
    }

    private void avanzar()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            _animator.SetBool("avanzar", true);
        }
        if (Input.GetButtonDown("Fire2"))
        {
            _animator.SetBool("avanzar", false);
        }
    }

    private void activarViento()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            _animator.SetFloat("viento", 0.5F);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            _animator.SetFloat("viento", 2);
        }
    }

    private void rotar()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            _animator.SetInteger("rotar", 2);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            _animator.SetInteger("rotar", 6);
        }
    }
}
