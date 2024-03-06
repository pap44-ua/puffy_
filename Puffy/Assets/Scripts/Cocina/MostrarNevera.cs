using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarNevera : MonoBehaviour
{
    public GameObject canvasNevera; // El Canvas de la nevera que quieres mostrar
    public GameObject comida; 

    public void mostrarNevera()
    {
        // Invierte el estado de activación del Canvas de la nevera
        canvasNevera.SetActive(!canvasNevera.activeSelf);
        comida.SetActive(!comida.activeSelf);
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
