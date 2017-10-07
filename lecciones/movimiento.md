# Movimientos básicos

* Añadimos una esfera.
* Creamos un script: ControladorJuego.cs
* Asignamos el script a la esfera

Para métodos de debug que se muestran por consola:

```cs
void Start()
{
  Debug.Log("ControladorJuego.Start()");
}

void Update()
{
  Debug.Log("ControladorJuego.Update()");
}
```

Esfera estática que rota a velocidad constante:

```cs
float velocidadRotacion = 1F;

transform.Rotate(new Vector3(0, velocidadRotacion, velocidadRotacion));
```

Aplicando movimiento a la esfera y usando eje de disparo:

```cs
transform.Translate(Input.GetAxis("Horizontal") * 0.1F, 0, Input.GetAxis("Vertical") * 0.1F);

if (Input.GetAxis("Fire1") != 0)
{
  print("¡Disparo!");
}
```