using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Import TMPro namespace

public class ContadorMonedasScript : MonoBehaviour
{/**
    public int monedasRecogidas; // Variable to store collected coins
    public TMP_Text textoMonedas; // Reference to the TextMeshPro counter object

    void Start()
    {
        // Ensure TextMeshPro reference is assigned in the Inspector
        if (textoMonedas == null)
        {
            Debug.LogError("No TextMeshPro object assigned to textoMonedas!");
        }
    }

    public void IncrementarMonedas()
    {
        monedasRecogidas++;
        textoMonedas.text = monedasRecogidas.ToString(); // Update text with formatted string
        Debug.Log("Monedas: " + monedasRecogidas);
    }

    private void OnMouseDown() // Detect click on the Puffy sprite
    {
        if (gameObject.name == "Puffy") // Check if clicked object is Puffy
        {
            IncrementarMonedas();
        }
    }**/
}
