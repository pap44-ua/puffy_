using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class contadorComida : MonoBehaviour
{
    public int cantidad;
    public TMP_Text texto;
    public GameObject canvasNevera;
    public GameObject comida;
    public String stringComida;
     private void extraerCantidad()
    {
        switch (gameObject.name)
        {
            case "Hamburguesa":
                Nevera.cantidadHamburguesa = PlayerPrefs.GetInt("cantidadHamburguesa");
                cantidad = Nevera.cantidadHamburguesa;
                stringComida = "cantidadHamburguesa";
                break;
            case "Pizza":
                Nevera.cantidadPizza = PlayerPrefs.GetInt("cantidadPizza");
                cantidad = Nevera.cantidadPizza;
                stringComida = "cantidadPizza";
                break;
            case "Sandía":
                Nevera.cantidadSandia = PlayerPrefs.GetInt("cantidadSandia");
                cantidad = Nevera.cantidadSandia;
                stringComida = "cantidadSandia";
                break;
            case "Fresa":
                Nevera.cantidadFresa = PlayerPrefs.GetInt("cantidadFresa");
                cantidad = Nevera.cantidadFresa;
                stringComida = "cantidadFresa";
                break;
            case "Croissant":
                Nevera.cantidadCroissant = PlayerPrefs.GetInt("cantidadCroissant");
                cantidad = Nevera.cantidadCroissant;
                stringComida = "cantidadCroissant";
                break;
            case "Cerezas":
                Nevera.cantidadCerezas = PlayerPrefs.GetInt("cantidadCerezas");
                cantidad = Nevera.cantidadCerezas;
                stringComida = "cantidadCerezas";
                break;
            case "Helado":
                Nevera.cantidadHelado = PlayerPrefs.GetInt("cantidadHelado");
                cantidad = Nevera.cantidadHelado;
                stringComida = "cantidadHelado";
                break;
            case "Galleta":
                Nevera.cantidadGalleta = PlayerPrefs.GetInt("cantidadGalleta");
                cantidad = Nevera.cantidadGalleta;
                stringComida = "cantidadGalleta";
                break;
            case "Banana":
                Nevera.cantidadBanana = PlayerPrefs.GetInt("cantidadBanana");
                cantidad = Nevera.cantidadBanana;
                stringComida = "cantidadBanana";
                break;
            case "Manzana":
                Nevera.cantidadManzana = PlayerPrefs.GetInt("cantidadManzana");
                cantidad = Nevera.cantidadManzana;
                stringComida = "cantidadManzana";
                break;
            case "Tortitas":
                Nevera.cantidadTortitas = PlayerPrefs.GetInt("cantidadTortitas");
                cantidad = Nevera.cantidadTortitas;
                stringComida = "cantidadTortitas";
                break;
            case "Perrito":
                Nevera.cantidadPerrito = PlayerPrefs.GetInt("cantidadPerrito");
                cantidad = Nevera.cantidadPerrito;
                stringComida = "cantidadPerrito";
                break;
        }
    }
    private void actualizarCantidad()
    {
        switch (gameObject.name)
        {
            case "Hamburguesa":
                Nevera.cantidadHamburguesa = cantidad;
                break;
            case "Pizza":
                Nevera.cantidadPizza = cantidad;
                break;
            case "Sandía":
                Nevera.cantidadSandia = cantidad;
                break;
            case "Fresa":
                Nevera.cantidadFresa = cantidad;
                break;
            case "Croissant":
                Nevera.cantidadCroissant = cantidad;
                break;
            case "Cerezas":
                Nevera.cantidadCerezas = cantidad;
                break;
            case "Helado":
                Nevera.cantidadHelado = cantidad;
                break;
            case "Galleta":
                Nevera.cantidadGalleta = cantidad;
                break;
            case "Banana":
                Nevera.cantidadBanana = cantidad;
                break;
            case "Manzana":
                Nevera.cantidadManzana = cantidad;
                break;
            case "Tortitas":
                Nevera.cantidadTortitas = cantidad;
                break;
            case "Perrito":
                Nevera.cantidadPerrito = cantidad;
                break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        extraerCantidad();
        texto.text = "x" + cantidad.ToString();

    }

    public void restarComida(){
        if(cantidad > 0)
        {
            cantidad--;
            texto.text = "x" + cantidad.ToString();
            PlayerPrefs.SetInt(stringComida, cantidad);
            actualizarCantidad();

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
