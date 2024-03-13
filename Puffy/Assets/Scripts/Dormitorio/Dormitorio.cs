using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dormitorio : MonoBehaviour
{
    public GameObject fondoOscuro;
    public GameObject iconoDormir;
    public GameObject ojosCerrados;


    // Start is called before the first frame update
    void Start()
    {
        fondoOscuro.SetActive(!fondoOscuro.activeSelf);
        iconoDormir.SetActive(!iconoDormir.activeSelf);
        ojosCerrados.SetActive(!ojosCerrados.activeSelf);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
