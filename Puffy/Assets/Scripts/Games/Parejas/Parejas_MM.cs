using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Parejas_MM : MonoBehaviour
{
    public GameObject playButton;
    public GameObject jugamosText;
    public GameObject reverso1;
    public GameObject reverso2;
    public GameObject reverso3;
    public GameObject reverso4;
    public GameObject reverso5;
    public GameObject reverso6;
    public GameObject reverso7;
    public GameObject reverso8;
    public GameObject reverso9;
    public GameObject reverso10;
    public GameObject reverso11;
    public GameObject reverso12;
    public GameObject reverso13;
    public GameObject reverso14;
    public GameObject reverso15;
    public GameObject reverso16;
    public GameObject reverso17;
    public GameObject reverso18;
    public GameObject reverso19;
    public GameObject reverso20;

    void Start()
    {
        reverso1.SetActive(false);
        reverso2.SetActive(false);
        reverso3.SetActive(false);
        reverso4.SetActive(false);
        reverso5.SetActive(false);
        reverso6.SetActive(false);
        reverso7.SetActive(false);
        reverso8.SetActive(false);
        reverso9.SetActive(false);
        reverso10.SetActive(false);
        reverso11.SetActive(false);
        reverso12.SetActive(false);
        reverso13.SetActive(false);
        reverso14.SetActive(false);
        reverso15.SetActive(false);
        reverso16.SetActive(false);
        reverso17.SetActive(false);
        reverso18.SetActive(false);
        reverso19.SetActive(false);
        reverso20.SetActive(false);
    }
    void OnMouseDown(){
        if(gameObject == playButton){
            playButton.SetActive(false);
            jugamosText.SetActive(false);

            reverso1.SetActive(true);
            reverso2.SetActive(true);
            reverso3.SetActive(true);
            reverso4.SetActive(true);
            reverso5.SetActive(true);
            reverso6.SetActive(true);
            reverso7.SetActive(true);
            reverso8.SetActive(true);
            reverso9.SetActive(true);
            reverso10.SetActive(true);
            reverso11.SetActive(true);
            reverso12.SetActive(true);
            reverso13.SetActive(true);
            reverso14.SetActive(true);
            reverso15.SetActive(true);
            reverso16.SetActive(true);
            reverso17.SetActive(true);
            reverso18.SetActive(true);
            reverso19.SetActive(true);
            reverso20.SetActive(true);
        }
        else{
            Debug.Log("No se ha encontrado el juego");
        }
    }

}