using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class Final : MonoBehaviour
{
    public GameObject atras;
    public GameObject reiniciar;

    // Start is called before the first frame update
    void Start()
    {
        atras = GameObject.Find("Atras");
        reiniciar = GameObject.Find("Reiniciar");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        if(gameObject == atras){
            Debug.Log("atras");

            SceneManager.LoadScene("Jardin");
        }
        else if(gameObject == reiniciar){
            Debug.Log("reiniciar");
            SceneManager.LoadScene("Parejas");
        }
    }
}
