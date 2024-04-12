using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class contadorPociones : MonoBehaviour
{
    public int cantidad = 2;
    public TMP_Text texto;
    public GameObject canvas;
    public GameObject pocion;
    // Start is called before the first frame update
    void Start()
    {
        texto.text = "x"+ cantidad.ToString();
    }

    public void restarpocion(){
        if(cantidad > 0){
            cantidad--;
            texto.text = "x"+ cantidad.ToString();
        }
    }
    void OnMouseDown()
    {
        OnMouseDown(1);
    }
     void OnMouseDown(int i){
        if(cantidad > 0){
            restarpocion();
            canvas.SetActive(false);
            pocion.SetActive(true);
        }
    }
   
}
