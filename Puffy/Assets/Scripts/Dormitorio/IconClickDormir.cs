using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconClickDormir : MonoBehaviour
{
    public GameObject fondoOscuro;
    public GameObject iconoDormir;
    public GameObject iconoDespierto;
    public GameObject ojosCerrados;
    public GameObject ojosAbiertos;
    public GameObject ojosCansados;
    public GameObject zzz;

    public LinearIndicator energia;
    public float tiempoDeSueno = 5f; // Tiempo en segundos que Puffy dormirá
    public float aumentoDeEnergiaPorSegundo = 5f; // Aumento de energía por segundo mientras Puffy duerme


    private bool estaDormido = false;
    private Coroutine corrutinaSueno;

    void Update()
    {
        ojosAbiertos.SetActive(false);
    }

    public void OnMouseDown()
    {
        if (!estaDormido)
        {
            corrutinaSueno = StartCoroutine(Dormir());
        }
        else
        {
            DetenerSueno();
        }
    }

    void DetenerSueno()
    {
        estaDormido = false;
        StopCoroutine(corrutinaSueno);

        fondoOscuro.SetActive(false);
        iconoDormir.SetActive(false);
        iconoDespierto.SetActive(true);
        ojosCerrados.SetActive(false);
        ojosAbiertos.SetActive(true);
        zzz.SetActive(false);
    }

    IEnumerator Dormir()
    {
        estaDormido = true;

        fondoOscuro.SetActive(true);
        iconoDormir.SetActive(true);
        iconoDespierto.SetActive(false);
        ojosCerrados.SetActive(true);
        ojosAbiertos.SetActive(false);
        ojosCansados.SetActive(false);
        zzz.SetActive(true);

        while (energia.GetValue() < 100f)
        {

            float aumentoDeEnergia = aumentoDeEnergiaPorSegundo * Time.deltaTime;
            energia.SetValue(Mathf.Clamp(energia.GetValue() + aumentoDeEnergia, 0f, 100f)); // Asegura que la energía no supere el 100%

            yield return null;

            // Salir de la corrutina si se hace clic nuevamente en el botón de dormir
            if (!estaDormido)
            {
                DetenerSueno();
                yield break;
            }
        }

        // Si la corrutina termina naturalmente sin ser detenida, despertar a Puffy
        DetenerSueno();
    }
}
