using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconClickDormir : MonoBehaviour
{
    public GameObject fondoOscuro;
    public GameObject iconoDormir;
    public GameObject iconoDespierto;
    public GameObject ojosCerrados;
    public GameObject ojosAbiertos;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown()
    {
        fondoOscuro.SetActive(!fondoOscuro.activeSelf);
        iconoDormir.SetActive(!iconoDormir.activeSelf);
        iconoDespierto.SetActive(!iconoDespierto.activeSelf);
        ojosCerrados.SetActive(!ojosCerrados.activeSelf);
        ojosAbiertos.SetActive(!ojosAbiertos.activeSelf);

    }
}
