using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mostrar_Comida : MonoBehaviour
{
    public GameObject canvasComida; // El Canvas de la nevera que quieres mostrar
    public GameObject canvasMenu;


    public void OnMouseDown()
    {
        // Invierte el estado de activación del Canvas de la nevera
        canvasComida.SetActive(true);
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
