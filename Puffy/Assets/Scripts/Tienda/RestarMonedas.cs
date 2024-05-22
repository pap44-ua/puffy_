using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RestarMonedas : MonoBehaviour
{
    public TMP_Text coinsText; // Referencia al componente TextMeshPro que muestra las monedas
    public int initialCoins = 1500; // Valor inicial de las monedas

    private int coins; // Variable para almacenar el n�mero de monedas

    void Start()
    {
        // Intenta cargar el n�mero de monedas desde PlayerPrefs
        coins = PlayerPrefs.GetInt("Coins", initialCoins);
        //ResetCoins();
        // Actualiza el texto del componente TextMeshPro con el valor inicial o cargado de las monedas
        UpdateCoinsText();
    }

    // M�todo para comprar un objeto. Recibe el costo del objeto como par�metro.
    public void BuyObject(int objectCost)
    {
        // Verifica si tienes suficientes monedas para comprar el objeto
        if (coins >= objectCost)
        {
            // Resta el costo del objeto del total de monedas
            coins -= objectCost;

            // Guarda el nuevo valor de las monedas en PlayerPrefs
            PlayerPrefs.SetInt("Coins", coins);

            // Actualiza el texto del componente TextMeshPro con el nuevo valor de las monedas
            UpdateCoinsText();
        }
        else
        {
            // Maneja el caso en el que el jugador no tiene suficientes monedas para comprar el objeto
            Debug.Log("No tienes suficientes monedas para comprar esto.");
        }
    }

    // M�todo para actualizar el texto del componente TextMeshPro con el valor actual de las monedas
    void UpdateCoinsText()
    {
        coinsText.text = "x" + coins.ToString();
    }

    // M�todo para restablecer el valor de las monedas a su valor inicial
    public void ResetCoins()
    {
        coins = initialCoins;
        PlayerPrefs.SetInt("Coins", coins);
        UpdateCoinsText();
    }
}
