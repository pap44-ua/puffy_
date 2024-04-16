using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Boton00, Boton01, Boton02, Boton10, Boton11, Boton12, Boton20, Boton21, Boton22;
    public GameObject Jugador1_00, Jugador1_01, Jugador1_02, Jugador1_10, Jugador1_11, Jugador1_12, Jugador1_20, Jugador1_21, Jugador1_22;
    public GameObject Jugador2_00, Jugador2_01, Jugador2_02, Jugador2_10, Jugador2_11, Jugador2_12, Jugador2_20, Jugador2_21, Jugador2_22;
    // Start is called before the first frame update
    void Start()
    {
        Boton00.SetActive(true);
        Boton01.SetActive(true);
        Boton02.SetActive(true); 
        Boton10.SetActive(true); 
        Boton11.SetActive(true); 
        Boton12.SetActive(true); 
        Boton20.SetActive(true); 
        Boton21.SetActive(true); 
        Boton22.SetActive(true);

    
        Jugador1_00.SetActive(false); 
        Jugador1_01.SetActive(false); 
        Jugador1_02.SetActive(false); 
        Jugador1_10.SetActive(false); 
        Jugador1_11.SetActive(false); 
        Jugador1_12.SetActive(false); 
        Jugador1_20.SetActive(false); 
        Jugador1_21.SetActive(false); 
        Jugador1_22.SetActive(false);

        Jugador2_00.SetActive(false); 
        Jugador2_01.SetActive(false); 
        Jugador2_02.SetActive(false); 
        Jugador2_10.SetActive(false); 
        Jugador2_11.SetActive(false); 
        Jugador2_12.SetActive(false); 
        Jugador2_20.SetActive(false); 
        Jugador2_21.SetActive(false); 
        Jugador2_22.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
