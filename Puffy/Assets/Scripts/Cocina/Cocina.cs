using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cocina : MonoBehaviour
{
    public GameObject canvasNevera;
    public GameObject hamburguesa;
    public GameObject pizza;
    public GameObject sandia;
    public GameObject croissant;
    public GameObject fresa;
    public GameObject cerezas;
    public GameObject helado;
    public GameObject galleta;
    public GameObject banana;
    public GameObject manzana;
    public GameObject tortitas;
    public GameObject perrito;
    
    // Start is called before the first frame update
    void Start()
    {
        canvasNevera.SetActive(!canvasNevera.activeSelf);
        hamburguesa.SetActive(!hamburguesa.activeSelf);
        pizza.SetActive(!pizza.activeSelf);
        sandia.SetActive(!sandia.activeSelf);
        croissant.SetActive(!croissant.activeSelf);
        fresa.SetActive(!fresa.activeSelf);
        cerezas.SetActive(!cerezas.activeSelf);
        helado.SetActive(!helado.activeSelf);
        galleta.SetActive(!galleta.activeSelf);
        banana.SetActive(!banana.activeSelf);
        manzana.SetActive(!manzana.activeSelf);
        tortitas.SetActive(!tortitas.activeSelf);
        perrito.SetActive(!perrito.activeSelf);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            // Itera a través de todos los toques que hay en la pantalla
            for (int i = 0; i < Input.touchCount; i++)
            {
                Touch touch = Input.GetTouch(i);

                // Comprueba si el toque está en fase de inicio
                if (touch.phase == TouchPhase.Began)
                {
                    // Convierte la posición del toque en la pantalla a una posición en el mundo 3D
                    Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

                    // Lanza un rayo desde la posición del toque hacia adelante para detectar colisiones con objetos
                    RaycastHit2D hit = Physics2D.Raycast(touchPosition, Vector2.zero);

                    // Comprueba si el rayo golpeó un objeto
                    if (hit.collider != null)
                    {
                        GameObject nevera = GameObject.Find("fridge");
                        GameObject boca = GameObject.Find("Boca");

                        if (hit.collider.gameObject == nevera)
                        {
                            hit.collider.gameObject.SendMessage("mostrarNevera");
                        }
                        if (hit.collider.gameObject == hamburguesa)
                        {
                            hamburguesa.SetActive(!hamburguesa.activeSelf);
                            boca.SendMessage("Comiendo");

                        }
                        if (hit.collider.gameObject == pizza)
                        {
                            pizza.SetActive(!pizza.activeSelf);
                            boca.SendMessage("Comiendo");
                        }
                        if (hit.collider.gameObject == sandia)
                        {
                            sandia.SetActive(!sandia.activeSelf);
                            boca.SendMessage("Comiendo");
                        }
                        if (hit.collider.gameObject == croissant)
                        {
                            croissant.SetActive(!croissant.activeSelf);
                            boca.SendMessage("Comiendo");
                        }
                        if (hit.collider.gameObject == fresa)
                        {
                            fresa.SetActive(!fresa.activeSelf);
                            boca.SendMessage("Comiendo");
                        }
                        if (hit.collider.gameObject == cerezas)
                        {
                            cerezas.SetActive(!cerezas.activeSelf);
                            boca.SendMessage("Comiendo");
                        }
                        if (hit.collider.gameObject == helado)
                        {
                            helado.SetActive(!helado.activeSelf);
                            boca.SendMessage("Comiendo");
                        }
                        if (hit.collider.gameObject == galleta)
                        {
                            galleta.SetActive(!galleta.activeSelf);
                            boca.SendMessage("Comiendo");
                        }
                        if (hit.collider.gameObject == banana)
                        {
                            banana.SetActive(!banana.activeSelf);
                            boca.SendMessage("Comiendo");
                        }
                        if (hit.collider.gameObject == manzana)
                        {
                            manzana.SetActive(!manzana.activeSelf);
                            boca.SendMessage("Comiendo");
                        }
                        if (hit.collider.gameObject == tortitas)
                        {
                            tortitas.SetActive(!tortitas.activeSelf);
                            boca.SendMessage("Comiendo");
                        }
                        if (hit.collider.gameObject == perrito)
                        {
                            perrito.SetActive(!perrito.activeSelf);
                            boca.SendMessage("Comiendo");
                        }
                        
                    }
                }
            }
        }
    }
}
