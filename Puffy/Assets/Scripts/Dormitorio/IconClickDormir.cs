using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
    public float energiaBajaThreshold = 25f;
    public float aumentoDeEnergiaPorSegundo = 5f; // Aumento de energía por segundo mientras Puffy duerme

    private bool estaDormido = false;
    private Coroutine corrutinaSueno;

    

    void  durmiendo()
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

        fondoOscuro.SetActive(!fondoOscuro.activeSelf);
        iconoDormir.SetActive(!iconoDormir.activeSelf);
        iconoDespierto.SetActive(!iconoDespierto.activeSelf);
        ojosCerrados.SetActive(!ojosCerrados.activeSelf);
        ojosAbiertos.SetActive(!ojosAbiertos.activeSelf);
        zzz.SetActive(!zzz.activeSelf);
    }

    IEnumerator Dormir()
    {
        estaDormido = true;

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
    public void OnMouseDown()
    {
        fondoOscuro.SetActive(!fondoOscuro.activeSelf);
        iconoDormir.SetActive(!iconoDormir.activeSelf);
        iconoDespierto.SetActive(!iconoDespierto.activeSelf);
        ojosCerrados.SetActive(!ojosCerrados.activeSelf);
        if (energia.GetValue() <= energiaBajaThreshold)
        {
       
            ojosCansados.SetActive(!ojosCansados.activeSelf);
        }
        else{
            ojosAbiertos.SetActive(!ojosAbiertos.activeSelf);
        }
        
        zzz.SetActive(!zzz.activeSelf);
    }
}
