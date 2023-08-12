using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMoveCharacter : MonoBehaviour
{
    public float speed = 2.0f; // Velocidad de movimiento
    public float leftBoundary = -5.0f; // L�mite izquierdo
    public float rightBoundary = 5.0f; // L�mite derecho

    private int direction = 1; // 1 para moverse a la derecha, -1 para moverse a la izquierda

    public void MoveCharacterAutomatically()
    {
        // Mueve al personaje en la direcci�n actual
        Vector3 newPosition = transform.position + Vector3.right * direction * speed * Time.deltaTime;
        transform.position = newPosition;

        // Cambia de direcci�n si llega a los l�mites
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
