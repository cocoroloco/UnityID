using UnityEngine;

public class PipeVerticalMovement : MonoBehaviour
{
    public float speed = 2f; // Velocidad de movimiento vertical
    public float range = 2f; // Amplitud del movimiento

    private float initialY; // Posición inicial en Y

    void Start()
    {
        // Guardamos la posición inicial en Y
        initialY = transform.position.y;
    }

    void Update()
    {
        // Calculamos la nueva posición en Y
        float newY = initialY + Mathf.Sin(Time.time * speed) * range;

        // Actualizamos la posición del objeto
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}

