using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimpiarCacas : MonoBehaviour
{  
   

   public void OcultarBurbujas()
    {
        
        gameObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        OcultarBurbujas();
    }
}