using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Parejas_MM : MonoBehaviour
{
    public GameObject playButton;
    public GameObject jugamosText;
    
    void Start()
    {
        
    }
    void OnMouseDown(){
        if(gameObject == playButton){
            playButton.SetActive(false);
            jugamosText.SetActive(false);
        }
        else{
            Debug.Log("No se ha encontrado el juego");
        }
    }

}