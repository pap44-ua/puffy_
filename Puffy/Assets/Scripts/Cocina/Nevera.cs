using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nevera : MonoBehaviour
{
    public List<Comida> listaDeComida;
    public GameObject comidaPrefab; // El prefab de comida
    public Transform panelUI; // El panel donde quieres mostrar la UI

    // Start is called before the first frame update
    void Start()
    {
        MostrarComidaEnUI();
    }

    void MostrarComidaEnUI()
    {
        foreach (Comida comidaItem in listaDeComida)
        {
            // Instanciar el prefab de comida
            GameObject comidaInstance = Instantiate(comidaPrefab, panelUI);
            
            // Puedes acceder al script de comida si necesitas información específica
            Comida comida = comidaInstance.GetComponent<Comida>();
            
            // Accede a los componentes de la comida para mostrar la información
            // Por ejemplo, si la imagen está en un componente Image y el nombre en un componente Text:
            Image imagenComida = comidaInstance.GetComponent<Image>();
            Text nombreComida = comidaInstance.GetComponent<Text>();
            
            // Asigna la imagen y el nombre
            imagenComida.sprite = comidaItem.imagen;
            nombreComida.text = comidaItem.nombre;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
