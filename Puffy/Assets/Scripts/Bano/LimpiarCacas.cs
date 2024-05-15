using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LimpiarCacas : MonoBehaviour
{

    public void OcultarSprites()
    {
        
        gameObject.SetActive(false); // Ocultar cada sprite en el array
       
    }

    private void OnMouseDown()
    {
        OcultarSprites(); // Llamar a la función para ocultar los sprites cuando se hace clic en el GameObject
    }
}
