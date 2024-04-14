using UnityEngine;

public class pelota : MonoBehaviour
{
    private Rigidbody2D rb;

    // Velocidad del balón
    public float speed = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Detectar el deslizamiento del dedo
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                // Obtener la posición actual del dedo y la posición anterior
                Vector2 touchDeltaPosition = touch.deltaPosition;

                // Calcular la dirección del deslizamiento
                Vector2 moveDirection = new Vector2(touchDeltaPosition.x, touchDeltaPosition.y);

                // Aplicar una fuerza al balón en la dirección del deslizamiento
                rb.AddForce(moveDirection * speed);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Si el balón colisiona con una pared, calcula el vector de rebote
        if (collision.gameObject.CompareTag("Wall"))
        {
            // Obtén la dirección del rebote (el vector reflejado del vector de velocidad actual)
            Vector2 normal = collision.contacts[0].normal;
            Vector2 direction = Vector2.Reflect(rb.velocity, normal).normalized;

            // Aplica la nueva dirección de movimiento al balón
            rb.velocity = direction * speed;
        }
        if (collision.gameObject.CompareTag("Porteria"))
        {
            // Muestra "GOOOOOOL" en la consola
            Debug.Log("GOOOOOOL");
        }
    }
}
