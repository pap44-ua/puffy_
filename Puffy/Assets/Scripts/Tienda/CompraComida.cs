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
        if (audioSource != null)
        {
            // Reproducir el sonido
            audioSource.Play();
            // Restar el costo de la comida de las monedas
            RestarMonedas();
        }
        if(this.gameObject.name == "Hamburguesa"){
            Nevera.cantidadHamburguesa++;
            PlayerPrefs.SetInt("cantidadHamburguesa", Nevera.cantidadHamburguesa);
        }
        
    }

    // M�todo para verificar si el objeto es visible en la c�mara
    

    // M�todo para restar el costo de la comida de las monedas
    void RestarMonedas()
    {
        // Busca el objeto CoinManager en la escena
        RestarMonedas coinManager = FindObjectOfType<RestarMonedas>();

        // Verifica si se encontr� el CoinManager
        if (coinManager != null)
        {
            // Resta el costo de la comida de las monedas usando el m�todo BuyObject del CoinManager
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
