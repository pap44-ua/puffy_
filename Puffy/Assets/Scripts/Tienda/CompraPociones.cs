using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompraPociones : MonoBehaviour
{
    public AudioSource audioSource;
    public int pocionCost = 50; // Costo de la comida

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
        sumarCantidad();

    }

    private void sumarCantidad()
    {
        switch (gameObject.name)
        {
            case "PocionDiversion":
               ArmarioPociones.cantidadPocionDiversion++;
               PlayerPrefs.SetInt("cantidadPocionDiversion", ArmarioPociones.cantidadPocionDiversion);
                break;
            case "PocionSalud":
                ArmarioPociones.cantidadPocionSalud++;
                PlayerPrefs.SetInt("cantidadPocionSalud", ArmarioPociones.cantidadPocionSalud);
                break;
            case "PocionComida":
                ArmarioPociones.cantidadPocionComida++;
                PlayerPrefs.SetInt("cantidadPocionComida", ArmarioPociones.cantidadPocionComida);
                break;
            case "PocionEnergia":
                ArmarioPociones.cantidadPocionEnergia++;
                PlayerPrefs.SetInt("cantidadPocionEnergia", ArmarioPociones.cantidadPocionEnergia);
                break;
            
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
            coinManager.BuyObject(pocionCost);
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
