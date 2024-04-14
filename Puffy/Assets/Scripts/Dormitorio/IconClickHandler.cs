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

    void Start()
    {
        
    }

    void Update() {

    }

    public void OnMouseDown()
    {
        fondoOscuro.SetActive(!fondoOscuro.activeSelf);
        iconoDormir.SetActive(!iconoDormir.activeSelf);
        iconoDespierto.SetActive(!iconoDespierto.activeSelf);
        ojosAbiertos.SetActive(!ojosAbiertos.activeSelf);
        ojosCerrados.SetActive(!ojosCerrados.activeSelf);
        zzz.SetActive(!zzz.activeSelf);

    }
}
