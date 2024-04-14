using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarPociones : MonoBehaviour
{
    public GameObject canvasLab; // El Canvas de la nevera que quieres mostrar
    public GameObject canvasMenu;


    public void OnMouseDown()
    {
        // Invierte el estado de activaci�n del Canvas de la nevera
        canvasLab.SetActive(true);
        canvasMenu.SetActive(false);

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
