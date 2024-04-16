using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompraComida : MonoBehaviour
{
    public AudioSource audioSource;

    void OnMouseDown()
    {
        // Verificar si se ha asignado un AudioSource y si el objeto es visible
        if (audioSource != null && isVisible())
        {
            // Reproducir el sonido
            audioSource.Play();
            // Agregar l�gica de a�adir comida a la nevera y gasto de monedas
        }
    }

    // M�todo para verificar si el objeto es visible en la c�mara
    bool isVisible()
    {
        if (GetComponent<Renderer>().isVisible)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

