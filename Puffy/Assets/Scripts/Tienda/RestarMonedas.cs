using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Diagnostics;

public class RestarMonedas : MonoBehaviour
{
    public TMP_Text coinsText; // Referencia al componente TextMeshPro que muestra las monedas
    public int coins = 1500; // Valor inicial de las monedas

    void Start()
    {
        // Actualiza el texto del componente TextMeshPro con el valor inicial de las monedas
        UpdateCoinsText();
    }

    // Método para comprar un objeto. Recibe el costo del objeto como parámetro.
    public void BuyObject(int objectCost)
    {
        // Verifica si tienes suficientes monedas para comprar el objeto
        if (coins >= objectCost)
        {
            // Resta el costo del objeto del total de monedas
            coins -= objectCost;

            // Actualiza el texto del componente TextMeshPro con el nuevo valor de las monedas
            UpdateCoinsText();
        }
        else
        {
        }
    }

    // Método para actualizar el texto del componente TextMeshPro con el valor actual de las monedas
    void UpdateCoinsText()
    {
        coinsText.text = "x" + coins.ToString();
    }
}
