using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class ExampleScriptLinearIndicator : MonoBehaviour
{

    public LinearIndicator comida, energia, salud, diversion;

    public float minValue, maxValue;
    public float currentValue;
    public int valComida, valEnergia, valSalud, valDiversion;
    void Start()
    {
        comida.SetupIndicator(0,100);
        energia.SetupIndicator(0, 100);
        salud.SetupIndicator(0, 100);
        diversion.SetupIndicator(0, 100);


        if (!PlayerPrefs.HasKey("Diversion") && !PlayerPrefs.HasKey("Comida") && !PlayerPrefs.HasKey("Energia") && !PlayerPrefs.HasKey("Salud"))
        {
            PlayerPrefs.SetInt("Comida", 10);
            PlayerPrefs.SetInt("Energia", 10);
            PlayerPrefs.SetInt("Salud", 10);
            PlayerPrefs.SetInt("Diversion", 10);
        }


        comida.SetValue(PlayerPrefs.GetInt("Comida"));
        diversion.SetValue(PlayerPrefs.GetInt("Diversion"));
        energia.SetValue(PlayerPrefs.GetInt("Energia"));
        salud.SetValue(PlayerPrefs.GetInt("Salud"));

    }

    public void modificarBarra(string nombre)
    {
        switch (nombre)
        {
            case "Comida":
                comida.SetValue(PlayerPrefs.GetInt("Comida"));
                break;
            case "Diversion":
                diversion.SetValue(PlayerPrefs.GetInt("Diversion"));
                break;
            case "Energia":
                energia.SetValue(PlayerPrefs.GetInt("Energia"));
                break;
            case "Salud":
                salud.SetValue(PlayerPrefs.GetInt("Salud"));
                break;
        }
    }

    void FixedUpdate()
    {
        if (!PlayerPrefs.HasKey("UltimaHora")){
            DateTime n = DateTime.Now;
            float r = n.Day * 86400 + n.Hour * 3600 + n.Minute * 60 + n.Second;
            PlayerPrefs.SetFloat("UltimaHora", r);
        }
        else{
            DateTime n = DateTime.Now;
            float r = n.Day * 86400 + n.Hour * 3600 + n.Minute * 60 + n.Second;
            float antes = PlayerPrefs.GetFloat("UltimaHora");
            float k = r - antes;

            if(k % 3600 >= 1)
            {

            }
        }

        if(comida.GetValue()==0 && diversion.GetValue()==0 && salud.GetValue()==0 && energia.GetValue()==0)
        {
            SceneManager.LoadScene("Muerto");
        }

        if(comida.GetValue() != PlayerPrefs.GetInt("Comida"))
            PlayerPrefs.SetInt("Comida", (int) comida.GetValue());
        
        if (diversion.GetValue() != PlayerPrefs.GetInt("Diversion"))
            PlayerPrefs.SetInt("Diversion", (int)diversion.GetValue());
     
        if (salud.GetValue() != PlayerPrefs.GetInt("Salud"))
            PlayerPrefs.SetInt("Salud", (int)salud.GetValue());
        
        if (energia.GetValue() != PlayerPrefs.GetInt("Energia"))
            PlayerPrefs.SetInt("Energia", (int)energia.GetValue());
    }
}
