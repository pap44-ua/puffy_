using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mostrar_Ropa : MonoBehaviour
{
    public GameObject canvasRopa; // El Canvas de la nevera que quieres mostrar
    public GameObject canvasMenu;
    public GameObject Atras;

    public void OnMouseDown()
    {
        // Invierte el estado de activaci�n del Canvas de la nevera
        canvasRopa.SetActive(true);
        canvasMenu.SetActive(false);
        Atras.SetActive(false);
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
