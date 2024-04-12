using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// TODO SPRINT 2: Cambiar a x1 cuando se compre ropa y a x0 cuando no lo haya comprado
public class contadorRopa : MonoBehaviour
{
    public int cantidad = 1;
    public TMP_Text texto;
    public GameObject canvasArmario;
    public GameObject ropa;
    // Start is called before the first frame update
    void Start()
    {
        texto.text = "x"+ cantidad.ToString();
    }

    public void OnMouseDown(){
        if(cantidad > 0){
            canvasArmario.SetActive(!canvasArmario.activeSelf);
            ropa.SetActive(!ropa.activeSelf);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
