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
    public GameObject BotonJugar, BotonSalir, FinJuego, Jugador1, Jugador2, MensajeGanador;
    private int turno, ganador;

    // Start is called before the first frame update
    void Start()
    {
        turno = 1;
        ganador = 0;
        
        BotonJugar.SetActive(false);
        BotonSalir.SetActive(false);
        FinJuego.SetActive(false);
        Jugador1.SetActive(false);
        Jugador2.SetActive(false);
        MensajeGanador.SetActive(false);

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
        if(ganador != 0)
        {
            FinJuego.SetActive(true);
            if (ganador == 1)
                Jugador1.SetActive(true);
            else 
                Jugador2.SetActive(true);

            BotonSalir.SetActive(true);
            BotonJugar.SetActive(true);
            MensajeGanador.SetActive(true);
        }
    }

    private void comprobarGanador()
    {
        //Horizontales
        if (Jugador1_00.activeSelf && Jugador1_01.activeSelf && Jugador1_02.activeSelf)
            ganador = 1;

        else if (Jugador1_10.activeSelf && Jugador1_11.activeSelf && Jugador1_12.activeSelf)
            ganador = 1;

        else if (Jugador1_20.activeSelf && Jugador1_21.activeSelf && Jugador1_22.activeSelf)
            ganador = 1;

        //Verticales
        else if (Jugador1_00.activeSelf && Jugador1_10.activeSelf && Jugador1_20.activeSelf)
            ganador = 1;

        else if (Jugador1_01.activeSelf && Jugador1_11.activeSelf && Jugador1_21.activeSelf)
            ganador = 1;

        else if (Jugador1_02.activeSelf && Jugador1_12.activeSelf && Jugador1_22.activeSelf)
            ganador = 1;

        //Diagonales
        else if (Jugador1_02.activeSelf && Jugador1_11.activeSelf && Jugador1_20.activeSelf)
            ganador = 1;

        else if (Jugador1_00.activeSelf && Jugador1_11.activeSelf && Jugador1_22.activeSelf)
            ganador = 1;



        //------------------------------------------------------------------------
        //Horizontales
        else if (Jugador2_00.activeSelf && Jugador2_01.activeSelf && Jugador2_02.activeSelf)
            ganador = 2;

        else if (Jugador2_10.activeSelf && Jugador2_11.activeSelf && Jugador2_12.activeSelf)
            ganador = 2;

        else if (Jugador2_20.activeSelf && Jugador2_21.activeSelf && Jugador2_22.activeSelf)
            ganador = 2;

        //Verticales
        else if (Jugador2_00.activeSelf && Jugador2_10.activeSelf && Jugador2_20.activeSelf)
            ganador = 2;

        else if (Jugador2_01.activeSelf && Jugador2_11.activeSelf && Jugador2_21.activeSelf)
            ganador = 2;

        else if (Jugador2_02.activeSelf && Jugador2_12.activeSelf && Jugador2_22.activeSelf)
            ganador = 2;

        //Diagonales
        else if (Jugador2_02.activeSelf && Jugador2_11.activeSelf && Jugador2_20.activeSelf)
            ganador = 2;

        else if (Jugador2_00.activeSelf && Jugador2_11.activeSelf && Jugador2_22.activeSelf)
            ganador = 2;

        if(ganador!=0)
        {

        }
    }

    private void siguienteTurno()
    {
        if (turno == 1)
            turno = 2;
        else
            turno = 1;
    }

    public void Button00Click()
    {
        if(!Jugador1_00.activeSelf && !Jugador2_00.activeSelf)
        {
            if(turno == 1)
                Jugador1_00.SetActive(true);
            else
                Jugador2_00.SetActive(true);
            Boton00.SetActive(false);
            siguienteTurno();
        }
        comprobarGanador();
    }

    public void Button01Click()
    {
        if (!Jugador1_01.activeSelf && !Jugador2_01.activeSelf)
        {
            if (turno == 1)
                Jugador1_01.SetActive(true);
            else
                Jugador2_01.SetActive(true);
            Boton01.SetActive(false);
            siguienteTurno();
        }
        comprobarGanador();
    }

    public void Button02Click()
    {
        if (!Jugador1_02.activeSelf && !Jugador2_02.activeSelf)
        {
            if (turno == 1)
                Jugador1_02.SetActive(true);
            else
                Jugador2_02.SetActive(true);
            Boton02.SetActive(false);
            siguienteTurno();
        }
        comprobarGanador();
    }

    public void Button10Click()
    {
        if (!Jugador1_10.activeSelf && !Jugador2_10.activeSelf)
        {
            if (turno == 1)
                Jugador1_10.SetActive(true);
            else
                Jugador2_10.SetActive(true);
            Boton10.SetActive(false);
            siguienteTurno();
        }
        comprobarGanador();
    }

    public void Button11Click()
    {
        if (!Jugador1_11.activeSelf && !Jugador2_11.activeSelf)
        {
            if (turno == 1)
                Jugador1_11.SetActive(true);
            else
                Jugador2_11.SetActive(true);
            Boton11.SetActive(false);
            siguienteTurno();
        }
        comprobarGanador();
    }

    public void Button12Click()
    {
        if (!Jugador1_12.activeSelf && !Jugador2_12.activeSelf)
        {
            if (turno == 1)
                Jugador1_12.SetActive(true);
            else
                Jugador2_12.SetActive(true);
            Boton12.SetActive(false);
            siguienteTurno();
        }
        comprobarGanador();
    }

    public void Button20Click()
    {
        if (!Jugador1_20.activeSelf && !Jugador2_20.activeSelf)
        {
            if (turno == 1)
                Jugador1_20.SetActive(true);
            else
                Jugador2_20.SetActive(true);
            Boton20.SetActive(false);
            siguienteTurno();
        }
        comprobarGanador();
    }

    public void Button21Click()
    {
        if (!Jugador1_21.activeSelf && !Jugador2_21.activeSelf)
        {
            if (turno == 1)
                Jugador1_21.SetActive(true);
            else
                Jugador2_21.SetActive(true);
            Boton21.SetActive(false);
            siguienteTurno();
        }
        comprobarGanador();
    }

    public void Button22Click()
    {
        if (!Jugador1_22.activeSelf && !Jugador2_22.activeSelf)
        {
            if (turno == 1)
                Jugador1_22.SetActive(true);
            else
                Jugador2_22.SetActive(true);
            Boton22.SetActive(false);
            siguienteTurno();
        }
        comprobarGanador();
    }

    public void volverAJugar()
    {
        turno = 1;
        ganador = 0;

        BotonJugar.SetActive(false);
        BotonSalir.SetActive(false);
        FinJuego.SetActive(false);
        Jugador1.SetActive(false);
        Jugador2.SetActive(false);
        MensajeGanador.SetActive(false);

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
}
