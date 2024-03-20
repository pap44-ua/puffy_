using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickJabon : MonoBehaviour
{
    public bool jabon;
    public GameObject prefabBurbujas;
    private Animator animacionBurbujas;

    public void MostrarBurbujas()
    {
        //GameObject burbujaInstanciada = Instantiate(prefabBurbujas, transform.position, Quaternion.identity);
        prefabBurbujas.SetActive(true);
        
        
    }

    private void OnMouseDown()
    {
        MostrarBurbujas();
    }
}
