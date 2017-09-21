# Proyecto "roll the ball"

Creando el juego _roll da ball_!

1. Añadir plano a resetear
2. Añadir esfera, que será el jugador
3. Creamos un controlador para jugador, un script en el que escribiremos un inicializador de objetos coleccionables y le dará un cuerpo rígido para las físicas.


```cs
public void Awake()
{
  cuerpoRigido = GetComponent<RigidBody>();
  contador = 0;
}
```
