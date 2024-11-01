using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Velocidad de rotación en el eje X
    public float rotationSpeed = 15f;

    // Amplitud y velocidad del movimiento en el eje Y
    public float floatAmplitude = 0.5f; // La cantidad que se mueve arriba y abajo
    public float floatFrequency = 1f;   // La velocidad a la que se mueve arriba y abajo

    // Posición inicial en el eje Y para referencia
    private float initialY;


    // Start se llama al iniciar el objeto
    void Start()
    {
        // Guardar la posición inicial en el eje Y
        initialY = transform.position.y;
    }

    // Update se llama una vez por frame
    void Update()
    {
        // Rotar sobre el eje X
        transform.Rotate(new Vector3(0, rotationSpeed, 0) * Time.deltaTime);

        // Movimiento arriba y abajo en el eje Y usando una función seno para un movimiento suave
        float newY = initialY + Mathf.Sin(Time.time * floatFrequency) * floatAmplitude;

        // Actualizar la posición del objeto
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
