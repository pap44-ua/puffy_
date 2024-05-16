using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickJabon : MonoBehaviour
{
    public AudioSource audio;
    public bool jabon;
    public GameObject prefabBurbujas;
    private Animator animacionBurbujas;

    public void MostrarBurbujas()
    {
        //GameObject burbujaInstanciada = Instantiate(prefabBurbujas, transform.position, Quaternion.identity);
        prefabBurbujas.SetActive(true);
        if(audio != null)
        {
            audio.Play();
        }
        
        
    }

    private void OnMouseDown()
    {
        MostrarBurbujas();
    }
}
