using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class ControlEnemigo : MonoBehaviour
{
    public GameObject personaje;
    public GameObject enemigo;

    int puntosDeVida = 5;

    void FixedUpdate()
    {
        GetComponent<NavMeshAgent>().SetDestination(personaje.transform.position);
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Bala")
        {
            puntosDeVida--;
            Debug.Log(puntosDeVida);
            if (puntosDeVida == 0)
            {
                Destroy(enemigo);
            }
        }
    }
}
