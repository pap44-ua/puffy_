using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurbujasScript : MonoBehaviour
{
    public bool mostrarBurbujas;
    public GameObject prefabBurbujas;

    public void GenerarBurbujas()
    {
        if (mostrarBurbujas)
        {
            Instantiate(prefabBurbujas, transform.position, Quaternion.identity);
        }
    }

    public void OcultarBurbujas()
    {
        prefabBurbujas.SetActive(false);
    }

    private void OnMouseDown()
    {
        mostrarBurbujas = true;
        GenerarBurbujas();
    }

    void Start()
    {
        mostrarBurbujas = false;
        OcultarBurbujas();
    }
}
