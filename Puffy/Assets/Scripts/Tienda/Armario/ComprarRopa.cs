using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ComprarRopa : MonoBehaviour
{

    public AudioSource audioSource;
    public int pocionCost = 50; // Costo de la comida

    void OnMouseDown()
    {
        if(CheckEnoughCoins())
        {
            sumarCantidad();
        }
        
    }
        bool CheckEnoughCoins()
    {
        int currentCoins = PlayerPrefs.GetInt("Coins", 0);
        return currentCoins >= pocionCost;
    }

    private void sumarCantidad()
    {
        switch (gameObject.name)
        {
            case "CamisetaAdidas":
               Armario.cantidadCamisetaAdidas++;
               PlayerPrefs.SetInt("cantidadCamisetaAdidas", Armario.cantidadCamisetaAdidas);
                break;
            case "CamisetaNike":
                Armario.cantidadCamisetaNike++;
                PlayerPrefs.SetInt("cantidadCamisetaNike", Armario.cantidadCamisetaNike);
                break;
            case "CamisetaAzul":
                Armario.cantidadCamisetaAzul++;
                PlayerPrefs.SetInt("cantidadCamisetaAzul", Armario.cantidadCamisetaAzul);
                break;
            case "SudaderaAdidas":
                Armario.cantidadSudaderaAdidas++;
                PlayerPrefs.SetInt("cantidadSudaderaAdidas", Armario.cantidadSudaderaAdidas);
                break;
            case "SudaderaNike":
                Armario.cantidadSudaderaNike++;
                PlayerPrefs.SetInt("cantidadSudaderaNike", Armario.cantidadSudaderaNike);
                break;
            case "PantalonesRojos":
                Armario.cantidadPantalonesRojos++;
                PlayerPrefs.SetInt("cantidadPantalonesRojos", Armario.cantidadPantalonesRojos);
                break;
            case "PantalonesLilas":
                Armario.cantidadPantalonesLilas++;
                PlayerPrefs.SetInt("cantidadPantalonesLilas", Armario.cantidadPantalonesLilas);
                break;
            case "VestidoRojo":
                Armario.cantidadVestidoRojo++;
                PlayerPrefs.SetInt("cantidadVestidoRojo", Armario.cantidadVestidoRojo);
                break;
            case "VestidoLila":
                Armario.cantidadVestidoLila++;
                PlayerPrefs.SetInt("cantidadVestidoLila", Armario.cantidadVestidoLila);
                break;
            case "ChaquetaAzul":
                Armario.cantidadChaquetaAzul++;
                PlayerPrefs.SetInt("cantidadChaquetaAzul", Armario.cantidadChaquetaAzul);
                break;
            case "ChaquetaGris":
                Armario.cantidadChaquetaGris++;
                PlayerPrefs.SetInt("cantidadChaquetaGris", Armario.cantidadChaquetaGris);
                break;
            case "Zapatillas":
                Armario.cantidadZapatillas++;
                PlayerPrefs.SetInt("cantidadZapatillas", Armario.cantidadZapatillas);
                break;
            case "Pantunflas":
                Armario.cantidadZapatillasCasa++;
                PlayerPrefs.SetInt("cantidadZapatillasCasa", Armario.cantidadZapatillasCasa);
                break;
            case "GorroDormir":
                Armario.cantidadGorroDormir++;
                PlayerPrefs.SetInt("cantidadGorroDormir", Armario.cantidadGorroDormir);
                break;
            case "Pulsera":
                Armario.cantidadPulsera++;
                PlayerPrefs.SetInt("cantidadPulsera", Armario.cantidadPulsera);
                break; 
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}