using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

// TODO SPRINT 2: Cambiar a x1 cuando se compre ropa y a x0 cuando no lo haya comprado
public class contadorRopa : MonoBehaviour
{
    public int cantidad;
    public TMP_Text texto;
    public GameObject canvasArmario;
    public GameObject ropa;
    public String stringRopa;

    private void extraerCantidad()
    {
        switch (gameObject.name)
        {
            case "camiseta_adidas":
                Armario.cantidadCamisetaAdidas = PlayerPrefs.GetInt("cantidadCamisetaAdidas");
                cantidad = Armario.cantidadCamisetaAdidas;
                stringRopa = "cantidadCamisetaAdidas";
                break;
            case "camiseta_nike":
                Armario.cantidadCamisetaNike = PlayerPrefs.GetInt("cantidadCamisetaNike");
                cantidad = Armario.cantidadCamisetaNike;
                stringRopa = "cantidadCamisetaNike";
                break;
            case "camiseta_azul":
                Armario.cantidadCamisetaAzul = PlayerPrefs.GetInt("cantidadCamisetaAzul");
                cantidad = Armario.cantidadCamisetaAzul;
                stringRopa = "cantidadCamisetaAzul";
                break;
            case "sudadera_adidas":
                Armario.cantidadSudaderaAdidas = PlayerPrefs.GetInt("cantidadSudaderaAdidas");
                cantidad = Armario.cantidadSudaderaAdidas;
                stringRopa = "cantidadSudaderaAdidas";
                break;
            case "sudadera_nike":
                Armario.cantidadSudaderaNike = PlayerPrefs.GetInt("cantidadSudaderaNike");
                cantidad = Armario.cantidadSudaderaNike;
                stringRopa = "cantidadSudaderaNike";
                break;
            case "pantalones_rojos":
                Armario.cantidadPantalonesRojos = PlayerPrefs.GetInt("cantidadPantalonesRojos");
                cantidad = Armario.cantidadPantalonesRojos;
                stringRopa = "cantidadPantalonesRojos";
                break;
            case "pantalones_lilas":
                Armario.cantidadPantalonesLilas = PlayerPrefs.GetInt("cantidadPantalonesLilas");
                cantidad = Armario.cantidadPantalonesLilas;
                stringRopa = "cantidadPantalonesLilas";
                break;
            case "vestido_lila":
                Armario.cantidadVestidoLila = PlayerPrefs.GetInt("cantidadVestidoLila");
                cantidad = Armario.cantidadVestidoLila;
                stringRopa = "cantidadVestidoLila";
                break;
            case "vestido_rojo":
                Armario.cantidadVestidoRojo = PlayerPrefs.GetInt("cantidadVestidoRojo");
                cantidad = Armario.cantidadVestidoRojo;
                stringRopa = "cantidadVestidoRojo";
                break;
            case "chaqueta_azul":
                Armario.cantidadChaquetaAzul = PlayerPrefs.GetInt("cantidadChaquetaAzul");
                cantidad = Armario.cantidadChaquetaAzul;
                stringRopa = "cantidadChaquetaAzul";
                break;
            case "chaqueta_gris":
                Armario.cantidadChaquetaGris = PlayerPrefs.GetInt("cantidadChaquetaGris");
                cantidad = Armario.cantidadChaquetaGris;
                stringRopa = "cantidadChaquetaGris";
                break;
            case "zapatillas":
                Armario.cantidadZapatillas = PlayerPrefs.GetInt("cantidadZapatillas");
                cantidad = Armario.cantidadZapatillas;
                stringRopa = "cantidadZapatillas";
                break;
            case "zapatillas_casa":
                Armario.cantidadZapatillasCasa = PlayerPrefs.GetInt("cantidadZapatillasCasa");
                cantidad = Armario.cantidadZapatillasCasa;
                stringRopa = "cantidadZapatillasCasa";
                break;
            case "gorroDormir":
                Armario.cantidadGorroDormir = PlayerPrefs.GetInt("cantidadGorroDormir");
                cantidad = Armario.cantidadGorroDormir;
                stringRopa = "cantidadGorroDormir";
                break;
            case "pulsera":
                Armario.cantidadPulsera = PlayerPrefs.GetInt("cantidadPulsera");
                cantidad = Armario.cantidadPulsera;
                stringRopa = "cantidadPulsera";
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        extraerCantidad();
        texto.text = "x"+ cantidad.ToString();
    }

    public void OnMouseDown()
    {
        if (cantidad > 0)
        {
            canvasArmario.SetActive(!canvasArmario.activeSelf);
            ropa.SetActive(!ropa.activeSelf);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }   

}
