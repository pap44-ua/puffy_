using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class contadorComida : MonoBehaviour
{
    public int cantidad = 2;
    public TMP_Text texto;
    public GameObject canvasNevera;
    public GameObject comida;
    // Start is called before the first frame update
    void Start()
    {
        texto.text = "x"+ cantidad.ToString();
    }

    public void restarComida(){
        if(cantidad > 0){
            cantidad--;
            texto.text = "x"+ cantidad.ToString();
        }
    }
    public void OnMouseDown(){
        if(cantidad > 0){
            restarComida();
            canvasNevera.SetActive(!canvasNevera.activeSelf);
            comida.SetActive(!comida.activeSelf);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
