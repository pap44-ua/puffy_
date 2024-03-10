using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitarBurbujas : MonoBehaviour
{
    public GameObject prefabBurbujas;


    public void MostrarBurbujas()
    {
        GameObject burbujaInstanciada = Instantiate(prefabBurbujas, transform.position, Quaternion.identity);
        burbujaInstanciada.SetActive(false); // Deactivate the instantiated bubble
        Debug.Log("Se deberia de ir");
        
        
    }

    private void OnMouseDown()
    {
        MostrarBurbujas();
    }
}
