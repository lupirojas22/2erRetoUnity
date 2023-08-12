using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMoveCharacter : MonoBehaviour
{
    public float speed = 2.0f; // Velocidad de movimiento
    public float leftBoundary = -5.0f; // Límite izquierdo
    public float rightBoundary = 5.0f; // Límite derecho

    private int direction = 1; // 1 para moverse a la derecha, -1 para moverse a la izquierda

    public void MoveCharacterAutomatically()
    {
        // Mueve al personaje en la dirección actual
        Vector3 newPosition = transform.position + Vector3.right * direction * speed * Time.deltaTime;
        transform.position = newPosition;

        // Cambia de dirección si llega a los límites
        if (transform.position.x > rightBoundary)
        {
            direction = -1;
            transform.rotation = Quaternion.Euler(0, 0, 0);

        }
        else if (transform.position.x < leftBoundary)
        {
            direction = 1;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }
}
