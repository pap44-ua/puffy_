using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System;

public class contadorPociones : MonoBehaviour
{
    public int cantidad;
    public TMP_Text texto;
    public GameObject canvas;
    public GameObject pocion;
    public String stringPocion;
     private void extraerCantidad()
    {
        switch (gameObject.name)
        {
            case "PocionDiversion":
                ArmarioPociones.cantidadPocionDiversion = PlayerPrefs.GetInt("cantidadPocionDiversion");
                cantidad = ArmarioPociones.cantidadPocionDiversion;
                stringPocion = "cantidadPocionDiversion";
                break;
            case "PocionSalud":
                ArmarioPociones.cantidadPocionSalud = PlayerPrefs.GetInt("cantidadPocionSalud");
                cantidad = ArmarioPociones.cantidadPocionSalud;
                stringPocion = "cantidadPocionSalud";
                break;
            case "PocionComida":
                ArmarioPociones.cantidadPocionComida = PlayerPrefs.GetInt("cantidadPocionComida");
                cantidad = ArmarioPociones.cantidadPocionComida;
                stringPocion = "cantidadPocionComida";
                break;
            case "PocionEnergia":
                ArmarioPociones.cantidadPocionEnergia = PlayerPrefs.GetInt("cantidadPocionEnergia");
                cantidad = ArmarioPociones.cantidadPocionEnergia;
                stringPocion = "cantidadPocionEnergia";
                break;
            
        }
    }
    private void actualizarCantidad()
    {
        switch (gameObject.name)
        {
            case "PocionDiversion":
                ArmarioPociones.cantidadPocionDiversion = cantidad;
                break;
            case "PocionSalud":
                ArmarioPociones.cantidadPocionSalud = cantidad;
                break;
            case "PocionComida":
                ArmarioPociones.cantidadPocionComida = cantidad;
                break;
            case "pocionEnergia":
                ArmarioPociones.cantidadPocionEnergia  = cantidad;
                break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        extraerCantidad();
        texto.text = "x" + cantidad.ToString();

    }

    public void restarPocion(){
        if(cantidad > 0)
        {
            cantidad--;
            texto.text = "x" + cantidad.ToString();
            PlayerPrefs.SetInt(stringPocion, cantidad);
            actualizarCantidad();

        }
    }

    public void OnMouseDown(){
        if(cantidad > 0){
            restarPocion();
            canvas.SetActive(false);
            pocion.SetActive(true);
        }
    }
   
}
