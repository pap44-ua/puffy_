using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MostrarJuegos : MonoBehaviour
{
    public GameObject canvasJuegos; // El Canvas de la nevera que quieres mostrar

    public void mostrarJuegos()
    {
        // Invierte el estado de activación del Canvas de la nevera
        canvasJuegos.SetActive(!canvasJuegos.activeSelf);

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


