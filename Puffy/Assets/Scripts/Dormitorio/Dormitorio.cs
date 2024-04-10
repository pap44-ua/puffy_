using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dormitorio : MonoBehaviour
{
    //Animator Anim;

    public GameObject fondoOscuro;
    public GameObject iconoDormir;
    public GameObject ojosCerrados;
    public GameObject zzz;
    public GameObject CanvasArmario;

    //public bool dormido = false;


    // Start is called before the first frame update
    void Start()
    {
        fondoOscuro.SetActive(!fondoOscuro.activeSelf);
        iconoDormir.SetActive(!iconoDormir.activeSelf);
        ojosCerrados.SetActive(!ojosCerrados.activeSelf);
        zzz.SetActive(!zzz.activeSelf);
        CanvasArmario.SetActive(!CanvasArmario.activeSelf);

    }

    // Update is called once per frame
    void Update()
    {
        //Anim.SetBool("dormido", dormido);
    }
}
