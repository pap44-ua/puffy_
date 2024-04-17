using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CompraComida : MonoBehaviour
{
    public AudioSource audioSource;
    public int comidaCost = 50; // Costo de la comida

    void OnMouseDown()
    {
        // Verificar si se ha asignado un AudioSource y si el objeto es visible
        if (audioSource != null && isVisible())
        {
            // Reproducir el sonido
            audioSource.Play();
            // Restar el costo de la comida de las monedas
            RestarMonedas();
        }
    }

    // Método para verificar si el objeto es visible en la cámara
    bool isVisible()
    {
        if (GetComponent<Renderer>().isVisible)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Método para restar el costo de la comida de las monedas
    void RestarMonedas()
    {
        // Busca el objeto CoinManager en la escena
        RestarMonedas coinManager = FindObjectOfType<RestarMonedas>();

        // Verifica si se encontró el CoinManager
        if (coinManager != null)
        {
            // Resta el costo de la comida de las monedas usando el método BuyObject del CoinManager
            coinManager.BuyObject(comidaCost);
        }
        else
        {
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
