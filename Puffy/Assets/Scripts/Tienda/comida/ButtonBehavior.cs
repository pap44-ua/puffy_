using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{
    public GameObject canvasComida; // El Canvas de la nevera que quieres mostrar
    public GameObject canvasMenu;

    public void OnClick()
    {
        canvasComida.SetActive(false);
        canvasMenu.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
