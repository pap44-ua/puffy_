using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitarBurbujas : MonoBehaviour
{  
    public AudioSource audio;
    public GameObject jabon;
    public GameObject burbujaInstanciada; 
    bool mostrarBurbujas = false;

   public void OcultarBurbujas()
    {

        AudioSource audioSource = jabon.GetComponent<AudioSource>();
        if (audioSource != null)
        {
            // Pausar el audio del jabon si está reproduciéndose
            if (audioSource.isPlaying)
            {
                audioSource.Pause();
            }
        }
        if (burbujaInstanciada != null)
        {
            burbujaInstanciada.SetActive(mostrarBurbujas);
        }

        if (audio != null)
        {
            audio.Play();
        }

    }

    private void OnMouseDown()
    {
        OcultarBurbujas();

    }
}
