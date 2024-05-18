using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompraPociones : MonoBehaviour
{
    public int comidaCost;
    
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
        return currentCoins >= comidaCost;
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

    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
    }
}
