using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MostrarArmario : MonoBehaviour
{
    public GameObject canvasArmario; // El Canvas de la nevera que quieres mostrar

    public void mostrarArmario()
    {
        // Invierte el estado de activación del Canvas de la nevera
        canvasArmario.SetActive(!canvasArmario.activeSelf);

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

