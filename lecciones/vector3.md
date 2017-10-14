# Clase Vector3

Existen Vector3s ya definidos para movimientos determinados, constantes para la Clase Vector3.

| Nombre | Valores del vector |
| --- | --- |
|Vector3.one | (1, 1, 1) |
|Vector3.zero | (0, 0, 0) |
|Vector3.right | (1, 0, 0) |
|Vector3.forward | (0, 0, 1) |
|Vector3.up | (0, 1, 0) |
|Vector3.left | (-1, 0, 0) |
|Vector3.back | (0, 0, -1) |
|Vector3.down | (0, -1, 0) |

Podemos multiplicar un Vector3 por un número, que el resultado se aplicará sobre los tres ejes que lo componen.

``` Vector3(1, 0, 0) * 10 = Vector3(10, 0, 0) ```

El componente Transform tiene propiedades ya definidas que generan Vector3s, para producir movimientos.

Para invertir las direcciones bastaría con multiplicar por -1.

También tiene una serie de funciones, que también se encuentran con el mismo nombre en las Clases Vector3 y Mathf, para gestionar un conjunto de valores que producen el movimiento.

* Movimiento acelerado.
* Movimiento desacelerado.
* Movimiento ping-pong, boomerang

Y muchos más.

Estos movimientos se hacen mediante interpolaciones, que es el cálculo a cada segmento de la ruta para alcanzar el punto objetivo.

Algunas funciones importantes:

| Nombre | Descripcion | Referencia|
| --- | --- | --- |
| Lerp() | Permite la animación lineal entre el punto A y el punto B. La posición del GO está en Position, y se modifica el valor de su Position para hacer avanzar el GO. El punto inicial no tiene por qué ser el objeto. | [Ver código en GitHub](../codigo/lerping.cs) |
| MoveTowards() | Produce un desplazamiento entre un punto de inicio es su punto actual. Casi como Lerp(), pero este produce un movimiento acelerado. El punto inicial es el objeto. | [Ver código en GitHub](../codigo/movetowards.cs)
