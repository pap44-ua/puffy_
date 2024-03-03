using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tienda : MonoBehaviour
{
    public GameObject menuTienda; // Referencia al GameObject que contiene el menú de tienda

    private void Start()
    {
        // Asegúrate de que el menú de tienda esté desactivado al iniciar el juego
        menuTienda.SetActive(false);
    }

    private void OnMouseDown()
    {
        // Activa el menú de tienda al hacer clic en el sprite de la tienda
        menuTienda.SetActive(true);
    }
}
