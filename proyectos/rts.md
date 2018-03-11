# RTS

Creando un RTS y entendiendo el proceso, gracias al tutorial de Hector Pulido. Puedes encontrar su contenido en:

* [El proyecto en GitHub](https://github.com/HectorPulido/Simple-RTS-Made-With-Unity/blob/c78419d8cf6916fd53b11cc995295fa50f25fc37/RTS-STREAM/Assets/Scripts/Core/MovileEntity.cs)
* [Su canal en YouTube](https://www.youtube.com/watch?v=0Te858o_Rqo), donde se encuentra el tutorial explicado paso a paso una vez ha sido completado
* [Su segundo canal en YouTube](https://www.youtube.com/user/Pnichoable/videos), donde están los directos resubidos con todo el proceso de creación

_happy gamedev!_

## Navegando entre _scripts_

Este es el script que van a tener la mayor parte de las unidades. Tienen un nombre, una salud, un coste, una descripción, una _preview_... y una marca de si es seleccionable. Por defecto es _true_, pero no lo será si es unidad enemiga. A partir de ahí escapa a nuestro control.

```cs
public class RtsEntity : MonoBehaviour
{

	// Valores a personalizar para cada tipo de unidad
    public string entityName;
    public int maxHealth;
    public int health;
    public int price;
    public Sprite preview;
    public string description;
    public FactionType faction;
    public bool isSelectable = true;

    public Renderer[] renderers;    

    void Start()
    {
        SetColor();
    }
    
    // Determina un color dependiendo de la facción a la que pertenezca:
    public void SetColor()
    {
        for (int i = 0; i < renderers.Length; i++)
        {
            renderers[i].material.color = faction == FactionType.faction_1 ? Color.blue : Color.green;
        }
    }


    // Detectando colisiones ante ataques enemigos, si el proyectil 
    //proviene de la facción enemiga, es cuando se hace daño
    // No hay porcentaje de daño, el ataque realiza daño de valor único
    // Sin fuego amigo
    void OnTriggerEnter(Collider col)
    {
        if (col.GetComponent<Proyectile>() != null)
        {
            var pro = col.GetComponent<Proyectile>();
            if (pro.faction != faction)
            {
                health -= pro.damage;
                CheckHealth();
                Destroy(pro.gameObject);
            }
        }
    }

    // Settear y comprobar la salud de cada unidad, muere si es cero y nunca puede tener más de su máximo valor
    public void CheckHealth()
    {
        if (health > maxHealth)
            health = maxHealth;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

}
```

Este es el script que genera un cuadrado para la pulsación prolongada con el mouse, creando un _Rect_ con las unidades que son seleccionables (las de nuestra facción en el juego).

```cs
public class UnitSelecter : MonoBehaviour {


    Vector2 startPos;
    Vector2 endPos;

    public Texture SelectionTexture;

    // Esta propiedad es pública y estática para poder acceder a ella desde la Clase MovileEntity,
    //que estudiamos justo a continuación
    public static Rect rect;

    void Update()
    {

    	// ¿Se está seleccionando unidades?
        if (Input.GetKey(KeyCode.Mouse0))
        {
        	// Si recién pulsamos, ¡punto de inicio!
        	// Si llevamos más rato, es el punto de final, la sección hacia la que queremos ampliar en drag
            if (Input.GetKeyDown(KeyCode.Mouse0))
                startPos = Input.mousePosition;
            else
                endPos = Input.mousePosition;
        }
        else
        {
            endPos = startPos = Vector2.zero;
        }
    }

    // Dibujando el Rect para selección de unidades
    // Control de posiciones relativas de X e Y en la matriz de Unity
    void OnGUI()
    {
        if (startPos != Vector2.zero && endPos != Vector2.zero)
        {
            rect = new Rect(startPos.x, Screen.height - startPos.y,
                                endPos.x - startPos.x,
                                startPos.y - endPos.y);

            // La textura es puramente gráfica, sin mayor valor que hacer 
            //notable la selección que estamos realizando
            GUI.DrawTexture(rect, SelectionTexture);
        }
    }
}
```

Movimiento para las unidades seleccionables

```cs
public class MovileEntity : MonoBehaviour
{
    public bool isSelected;
    public GameObject selectionSphere;

    NavMeshAgent navMeshAgent;
    public RtsEntity entidadRTS;
    RaycastHit impactoRaycast;
    
    Vector3 Target;
    
    public Vector3 target
    {
        get { return Target; }
        set {
            Target = value;
            navMeshAgent.SetDestination(Target);
        }
    }

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        entidadRTS = GetComponent<RtsEntity>();
        // Cuando se inicializa, no se mueve, se queda justo en el punto donde está
        target = transform.position;
    }

    void Update()
    {
        // Si no es seleccionable, si no es de nuestra facción, no responde
        if (!entidadRTS.isSelectable)
            return;
        if (isSelected)
        {
            // Obteniendo el puntero del ratón, ¿hacia donde se moverán?
            if (Input.GetMouseButtonUp(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out impactoRaycast))
                {
                    SendMessage("MouseUp", impactoRaycast, SendMessageOptions.DontRequireReceiver);

                    if (impactoRaycast.collider != null)
                    {
                        if (impactoRaycast.collider.CompareTag("Terrain"))
                        {
                            target = impactoRaycast.point;
                        }
                    }                
                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            var pos = Camera.main.WorldToScreenPoint(transform.position);
            pos.y = Screen.height - pos.y;

            isSelected = UnitSelecter.rect.Contains(pos, true);
            selectionSphere.SetActive(isSelected);
        }
    }
}
```
