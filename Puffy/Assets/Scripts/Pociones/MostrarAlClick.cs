using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarAlClick : MonoBehaviour
{
    public GameObject nevera;
    public GameObject pocion;
    // Start is called before the first frame update

    public void OnMouseDown()
    {
        nevera.SetActive(false);
        pocion.SetActive(true);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
