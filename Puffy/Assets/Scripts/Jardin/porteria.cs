using UnityEngine;

public class porteria : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el objeto que entra en la portería es la pelota
        if (other.CompareTag("Pelota"))
        {
            // Muestra "GOOOOLL" en la consola
            Debug.Log("GOOOOLL PORTERIA");
        }
    }
}
