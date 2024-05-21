using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Boton00, Boton01, Boton02, Boton10, Boton11, Boton12, Boton20, Boton21, Boton22, BotonIA, BotonHumano;
    public GameObject Jugador1_00, Jugador1_01, Jugador1_02, Jugador1_10, Jugador1_11, Jugador1_12, Jugador1_20, Jugador1_21, Jugador1_22;
    public GameObject Jugador2_00, Jugador2_01, Jugador2_02, Jugador2_10, Jugador2_11, Jugador2_12, Jugador2_20, Jugador2_21, Jugador2_22;
    public GameObject BotonJugar, BotonSalir, FinJuego, Jugador1, Jugador2, MensajeGanador, Inicio;
    public AudioClip ganado, perdido;
    public AudioSource a;
    private int turno, ganador;
    private int enemigo;
    private int ganadas; 
    // Start is called before the first frame update
    void Start()
    {
        ganadas = 0;
        turno = 1;
        ganador = 0;
        enemigo = -1;
        BotonJugar.SetActive(false);
        BotonSalir.SetActive(false);
        FinJuego.SetActive(false);
        Jugador1.SetActive(false);
        Jugador2.SetActive(false);
        MensajeGanador.SetActive(false);
        Inicio.SetActive(true);
        Boton00.SetActive(false);
        Boton01.SetActive(false);
        Boton02.SetActive(false);
        Boton10.SetActive(false);
        Boton11.SetActive(false);
        Boton12.SetActive(false);
        Boton20.SetActive(false);
        Boton21.SetActive(false);
        Boton22.SetActive(false);
        BotonIA.SetActive(true);
        BotonHumano.SetActive(true);
    
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
            if (enemigo == 1)
            {
                a.PlayOneShot(ganado);
            }
            else if (enemigo == 0 && ganador == 1)
            {
                a.PlayOneShot(ganado);
            }
            else
                a.PlayOneShot(perdido);
        }
        if(enemigo == 0 && turno == 2)
        {
            colocarFichaIA();
            siguienteTurno();
            comprobarGanador();
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
            if (ganador == 2)
                ganadas++;
        }
    }

    private void colocarFichaIA()
    {
        if (Boton00.activeSelf)
        {
            Jugador2_00.SetActive(true);
            Boton00.SetActive(false);
        }
        else if (Boton01.activeSelf)
        {
            Jugador2_01.SetActive(true);
            Boton01.SetActive(false);
        }
        else if (Boton02.activeSelf)
        {
            Jugador2_01.SetActive(true);
            Boton02.SetActive(false);
        }
        else if (Boton10.activeSelf)
        {
            Jugador2_10.SetActive(true);
            Boton10.SetActive(false);
        }
        else if (Boton11.activeSelf)
        {
            Jugador2_11.SetActive(true);
            Boton11.SetActive(false);
        }
        else if (Boton12.activeSelf)
        {
            Jugador2_12.SetActive(true);
            Boton12.SetActive(false);   
        }
        else if (Boton20.activeSelf)
        {
            Jugador2_20.SetActive(true);
            Boton20.SetActive(false);
        }
        else if (Boton21.activeSelf)
        {
            Jugador2_21.SetActive(true);
            Boton21.SetActive(false);
        }
        else
        {
            Jugador2_22.SetActive(true);
            Boton22.SetActive(false);
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

    static int GenerarAleatorio(int semilla)
    {
        return (7919 * semilla + 104729) % 2855981;
    }

    public void BotonIAClick()
    {
        DateTime ahora = DateTime.Now;
        int semilla = ahora.Millisecond;
        Inicio.SetActive(false);
        BotonHumano.SetActive(false);
        BotonIA.SetActive(false);
        enemigo = 0;
        turno = GenerarAleatorio(semilla) % 2 +1;
        Boton00.SetActive(true);
        Boton01.SetActive(true);
        Boton02.SetActive(true);
        Boton10.SetActive(true);
        Boton11.SetActive(true);
        Boton12.SetActive(true);
        Boton20.SetActive(true);
        Boton21.SetActive(true);
        Boton22.SetActive(true);
    }

    public void BotonHumanoClick()
    {
        Inicio.SetActive(false);
        BotonHumano.SetActive(false );
        BotonIA.SetActive(false);
        enemigo = 1;
        Boton00.SetActive(true);
        Boton01.SetActive(true);
        Boton02.SetActive(true);
        Boton10.SetActive(true);
        Boton11.SetActive(true);
        Boton12.SetActive(true);
        Boton20.SetActive(true);
        Boton21.SetActive(true);
        Boton22.SetActive(true);
    }

    public void volverAJugar()
    {
        turno = 1;
        ganador = 0;
        enemigo = -1;
        BotonJugar.SetActive(false);
        BotonSalir.SetActive(false);
        FinJuego.SetActive(false);
        Jugador1.SetActive(false);
        Jugador2.SetActive(false);
        MensajeGanador.SetActive(false);
        Inicio.SetActive(true);
        Boton00.SetActive(false);
        Boton01.SetActive(false);
        Boton02.SetActive(false);
        Boton10.SetActive(false);
        Boton11.SetActive(false);
        Boton12.SetActive(false);
        Boton20.SetActive(false);
        Boton21.SetActive(false);
        Boton22.SetActive(false);
        BotonIA.SetActive(true);
        BotonHumano.SetActive(true);

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
    
    public void botonSalir()
    {
        int monedas = PlayerPrefs.GetInt("Coins");
        monedas += (ganadas * 2);
        PlayerPrefs.SetInt("Coins", monedas);
        SceneManager.LoadScene("Jardin");
    }
}
