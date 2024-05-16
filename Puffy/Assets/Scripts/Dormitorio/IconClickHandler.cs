using UnityEngine;
using UnityEngine.UI;

public class IconClickHandler : MonoBehaviour
{
    public GameObject fondoOscuro;
    public GameObject iconoDormir;
    public GameObject iconoDespierto;
    public GameObject ojosAbiertos;
    public GameObject ojosCerrados;
    public GameObject zzz;

    public LinearIndicator energia;
    public float energiaBajaThreshold = 25f;
    public GameObject ojosCansados;
    //private bool estaDormido = false;

    void Start()
    {
        
    }

    void Update() {
        // Verificar si la energía es baja y cambiar los ojos

        if (energia.GetValue() <= energiaBajaThreshold)
        {
            ojosAbiertos.SetActive(false);
            ojosCansados.SetActive(true);
        }
        else
        {
            ojosAbiertos.SetActive(true);
            ojosCansados.SetActive(false);
        }
    }

    public void OnMouseDown()
    {
        fondoOscuro.SetActive(!fondoOscuro.activeSelf);
        iconoDormir.SetActive(!iconoDormir.activeSelf);
        iconoDespierto.SetActive(!iconoDespierto.activeSelf);
        
        //ojosAbiertos.SetActive(false);
        ojosCerrados.SetActive(!ojosCerrados.activeSelf);
        //ojosCansados.SetActive(!ojosCansados.activeSelf);
        zzz.SetActive(!zzz.activeSelf);

    }
}
