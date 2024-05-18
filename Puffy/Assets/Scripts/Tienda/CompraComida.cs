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
            if(CheckEnoughCoins())
            {
            // Reproducir el sonido
            audioSource.Play();
            // Restar el costo de la comida de las monedas
            RestarMonedas();
            }
        }
        sumarCantidad();
    }

    bool CheckEnoughCoins()
    {
        int currentCoins = PlayerPrefs.GetInt("Coins", 0);
        return currentCoins >= comidaCost;
    }



    private void sumarCantidad()
    {
        switch (gameObject.name)
        {
            case "Hamburguesa":
                Nevera.cantidadHamburguesa++;
                PlayerPrefs.SetInt("cantidadHamburguesa", Nevera.cantidadHamburguesa);
                break;
            case "Pizza":
                Nevera.cantidadPizza++;
                PlayerPrefs.SetInt("cantidadPizza", Nevera.cantidadPizza);
                break;
            case "Sandía":
                Nevera.cantidadSandia++;
                PlayerPrefs.SetInt("cantidadSandia", Nevera.cantidadSandia);
                break;
            case "Fresa":
                Nevera.cantidadFresa++;
                PlayerPrefs.SetInt("cantidadFresa", Nevera.cantidadFresa);
                break;
            case "Croissant":
                Nevera.cantidadCroissant++;
                PlayerPrefs.SetInt("cantidadCroissant", Nevera.cantidadCroissant);
                break;
            case "Cerezas":
                Nevera.cantidadCerezas++;
                PlayerPrefs.SetInt("cantidadCerezas", Nevera.cantidadCerezas);
                break;
            case "Helado":
                Nevera.cantidadHelado++;
                PlayerPrefs.SetInt("cantidadHelado", Nevera.cantidadHelado);
                break;
            case "Galleta":
                Nevera.cantidadGalleta++;
                PlayerPrefs.SetInt("cantidadGalleta", Nevera.cantidadGalleta);
                break;
            case "Banana":
                Nevera.cantidadBanana++;
                PlayerPrefs.SetInt("cantidadBanana", Nevera.cantidadBanana);
                break;
            case "Manzana":
                Nevera.cantidadManzana++;
                PlayerPrefs.SetInt("cantidadManzana", Nevera.cantidadManzana);
                break;
            case "Tortitas":
                Nevera.cantidadTortitas++;
                PlayerPrefs.SetInt("cantidadTortitas", Nevera.cantidadTortitas);
                break;
            case "Perrito":
                Nevera.cantidadPerrito++;
                PlayerPrefs.SetInt("cantidadPerrito", Nevera.cantidadPerrito);
                break;
        }
    }

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
