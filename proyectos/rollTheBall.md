# Proyecto "roll the ball"

Creando el juego _roll da ball_!

### Movimiento para la bola

1. Añadir plano a resetear
2. Añadir esfera, que será el jugador
3. Añadimos a la esfera un componente RigidBody
4. Creamos un controlador para jugador, un script en el que escribiremos un inicializador de objetos coleccionables y le dará un cuerpo rígido para las físicas.
5. Asigna el script creado a la esfera

En este controlador, accedemos al RigidBody:

```cs
public void Awake()
{
  cuerpoRigido = GetComponent<RigidBody>();
  contador = 0;
}
```

Definimos en el script una variable de velocidad, que será pública, para poder modificarla desde el entorno de Unity:

```cs
public float velocidad;
```

En el método FixedUpdate(), obtenemos las teclas de la cruceta pulsadas y se las aplicamos al RigidBody multiplicadas por la velocidad.

```cs
public void FixedUpdate()
{
  float movHorizontal = Input.GetAxis("Horizontal");
  float movVertical = Input.GetAxis("Vertical");

  definirMovimiento = new Vector3(movHorizontal, 0, movVertical);

  cuerpoRigido.AddForce(definirMovimiento * velocidad);
}
```

No te olvides de darle un valor a la velocidad. Ejecuta y verás cómo la bola comienza a girar, colisionando con las paredes.

### Seguimiento de cámara

### Coleccionables

### Marcador

### Salida del juego

Para cualquier objeto que permnezco vivo durante todo el juego, asignamos un nuevo script.

En el método Update, para escuchar constantemente si pulsamos la tecla ESCAPE, para salir del juego.

```cs
void Update()
{
  if (Input.GetKeyDown(KeyCode.Escape))
  {
    Application.Quit();
  }
}
```