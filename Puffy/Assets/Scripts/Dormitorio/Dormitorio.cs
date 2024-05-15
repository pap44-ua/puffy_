using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dormitorio : MonoBehaviour
{
    //Animator Anim;

    public GameObject fondoOscuro;
    public GameObject iconoDormir;
    public GameObject ojosCerrados;
    public GameObject zzz;
    public GameObject CanvasArmario;
    public GameObject camisetaAdidas;
    public GameObject camisetaNike;
    public GameObject camisetaAzul;
    public GameObject sudaderaAdidas;
    public GameObject sudaderaNike;
    public GameObject chaquetaAzul;
    public GameObject chaquetaGris;
    public GameObject gorroDormir;
    public GameObject pantalonesLilas;
    public GameObject pantalonesRojos;
    public GameObject pulsera;
    public GameObject tatuaje;
    public GameObject vestidoLila;
    public GameObject vestidoRojo;
    public GameObject zapatillas;
    public GameObject pantunflas;

    public LinearIndicator energia;
    public float energiaBajaThreshold = 25f;
    public GameObject ojosCansados;
    public GameObject ojosAbiertos;


    // Start is called before the first frame update
    void Start()
    {
        fondoOscuro.SetActive(!fondoOscuro.activeSelf);
        iconoDormir.SetActive(!iconoDormir.activeSelf);
        ojosCerrados.SetActive(!ojosCerrados.activeSelf);
        zzz.SetActive(!zzz.activeSelf);
        CanvasArmario.SetActive(!CanvasArmario.activeSelf);
        camisetaAdidas.SetActive(false);
        camisetaNike.SetActive(false);
        camisetaAzul.SetActive(false);
        sudaderaAdidas.SetActive(false);
        sudaderaNike.SetActive(false);
        chaquetaAzul.SetActive(false);
        chaquetaGris.SetActive(false);
        gorroDormir.SetActive(false);
        pantalonesLilas.SetActive(false);
        pantalonesRojos.SetActive(false);
        pulsera.SetActive(false);
        tatuaje.SetActive(false);
        vestidoLila.SetActive(false);
        vestidoRojo.SetActive(false);
        zapatillas.SetActive(false);
        pantunflas.SetActive(false);

        // Verificar si la energía es baja y cambiar los ojos
        if (energia.GetValue() <= energiaBajaThreshold)
        {
            ojosAbiertos.SetActive(false);
            ojosCansados.SetActive(true);
        }
        else
        {
            ojosAbiertos.SetActive(true);
            ojosCansados.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
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
                        GameObject armario = GameObject.Find("armario");

                        if (hit.collider.gameObject == armario)
                        {
                            // Ejecuta la lógica específica para el objeto deseado
                            hit.collider.gameObject.SendMessage("mostrarArmario");
                        }
                        if (hit.collider.gameObject == camisetaAdidas)
                        {
                            // Ejecuta la lógica específica para el objeto deseado
                            camisetaAdidas.SetActive(!camisetaAdidas.activeSelf);
                        }
                        if (hit.collider.gameObject == camisetaNike)
                        {
                            // Ejecuta la lógica específica para el objeto deseado
                            camisetaNike.SetActive(!camisetaNike.activeSelf);
                        }
                        if (hit.collider.gameObject == camisetaAzul)
                        {
                            // Ejecuta la lógica específica para el objeto deseado
                            camisetaAzul.SetActive(!camisetaAzul.activeSelf);
                        }
                        if (hit.collider.gameObject == sudaderaAdidas)
                        {
                            // Ejecuta la lógica específica para el objeto deseado
                            sudaderaAdidas.SetActive(!sudaderaAdidas.activeSelf);
                        }
                        if (hit.collider.gameObject == sudaderaNike)
                        {
                            // Ejecuta la lógica específica para el objeto deseado
                            sudaderaNike.SetActive(!sudaderaNike.activeSelf);
                        }
                        if (hit.collider.gameObject == chaquetaAzul)
                        {
                            // Ejecuta la lógica específica para el objeto deseado
                            chaquetaAzul.SetActive(!chaquetaAzul.activeSelf);
                        }
                        if (hit.collider.gameObject == chaquetaGris)
                        {
                            // Ejecuta la lógica específica para el objeto deseado
                            chaquetaGris.SetActive(!chaquetaGris.activeSelf);
                        }
                        if (hit.collider.gameObject == gorroDormir)
                        {
                            // Ejecuta la lógica específica para el objeto deseado
                            gorroDormir.SetActive(!gorroDormir.activeSelf);
                        }
                        if (hit.collider.gameObject == pantalonesLilas)
                        {
                            // Ejecuta la lógica específica para el objeto deseado
                            pantalonesLilas.SetActive(!pantalonesLilas.activeSelf);
                        }
                        if (hit.collider.gameObject == pantalonesRojos)
                        {
                            // Ejecuta la lógica específica para el objeto deseado
                            pantalonesRojos.SetActive(!pantalonesRojos.activeSelf);
                        }
                        if (hit.collider.gameObject == pulsera)
                        {
                            // Ejecuta la lógica específica para el objeto deseado
                            pulsera.SetActive(!pulsera.activeSelf);
                        }
                        if (hit.collider.gameObject == tatuaje)
                        {
                            // Ejecuta la lógica específica para el objeto deseado
                            tatuaje.SetActive(!tatuaje.activeSelf);
                        }
                        if (hit.collider.gameObject == vestidoLila)
                        {
                            // Ejecuta la lógica específica para el objeto deseado
                            vestidoLila.SetActive(!vestidoLila.activeSelf);
                        }
                        if (hit.collider.gameObject == vestidoRojo)
                        {
                            // Ejecuta la lógica específica para el objeto deseado
                            vestidoRojo.SetActive(!vestidoRojo.activeSelf);
                        }
                        if (hit.collider.gameObject == zapatillas)
                        {
                            // Ejecuta la lógica específica para el objeto deseado
                            zapatillas.SetActive(!zapatillas.activeSelf);
                        }
                        if (hit.collider.gameObject == pantunflas)
                        {
                            // Ejecuta la lógica específica para el objeto deseado
                            pantunflas.SetActive(!pantunflas.activeSelf);
                        }

                    }
                }
            }
        }
    }
}
