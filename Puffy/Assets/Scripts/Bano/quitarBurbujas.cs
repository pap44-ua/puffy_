using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitarBurbujas : MonoBehaviour
{  
    public GameObject burbujaInstanciada; 
    bool mostrarBurbujas = false;

   public void OcultarBurbujas()
    {
        if (burbujaInstanciada != null)
        {
            burbujaInstanciada.SetActive(mostrarBurbujas);
        }
    }

    private void OnMouseDown()
    {
        OcultarBurbujas();

    }
}
