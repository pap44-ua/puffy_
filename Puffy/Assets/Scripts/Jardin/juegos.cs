using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class juegos : MonoBehaviour
{
    public GameObject ahorcado;
    public GameObject ppt;
    public GameObject memoria;
    public GameObject tresRaya;

    void OnMouseDown(){
        if(gameObject == ahorcado){
            SceneManager.LoadScene("Ahorcado");
        }
        else if(gameObject == ppt){
            SceneManager.LoadScene("PPT_MainMenu");
        }
        else if(gameObject == memoria){
            Debug.Log("Ha elegido memoria");
        }
        else if(gameObject == tresRaya){
            SceneManager.LoadScene("Tres_en_raya");
        }
        else{
            Debug.Log("No se ha encontrado el juego");
        }
    }
}
