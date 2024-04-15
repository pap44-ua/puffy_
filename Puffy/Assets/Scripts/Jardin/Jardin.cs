using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jardin : MonoBehaviour
{
    public GameObject canvasJuegos;

    // Start is called before the first frame update
    void Start()
    {
        canvasJuegos.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Anim.SetBool("dormido", dormido);
        if (Input.touchCount > 0)
        {
            // Itera a través de todos los toques que hay en la pantalla
            for (int i = 0; i < Input.touchCount; i++)
            {
                Touch touch = Input.GetTouch(i);

                // Comprueba si el toque está en fase de inicio
                if (touch.phase == TouchPhase.Began)
                {
                    // Convierte la posición del toque en la pantalla a una posición en el mundo 3D
                    Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

                    // Lanza un rayo desde la posición del toque hacia adelante para detectar colisiones con objetos
                    RaycastHit2D hit = Physics2D.Raycast(touchPosition, Vector2.zero);

                    // Comprueba si el rayo golpeó un objeto
                    if (hit.collider != null)
                    {
                        GameObject juegos = GameObject.Find("juegos");

                        if (hit.collider.gameObject == juegos)
                        {
                            // Ejecuta la lógica específica para el objeto deseado
                            hit.collider.gameObject.SendMessage("mostrarJuegos");
                        }

                    }
                }
            }
        }
    }
}
