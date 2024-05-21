using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;
using Random = System.Random;

public class MainAhorcado : MonoBehaviour
{
    //Partes Cuerpo
    public GameObject inicio, segundo, tercero, cuarto, quinto, sexto, septimo, octavo;

    //Recuadros
    public GameObject recuadroTeclado, recuadroPalabra, recuadroLetras;

    //Recuadro Final Partida
    public GameObject FinPartida, botonSalir, volverJugar, mensajeFinal;

    //Textos dinámicos
    public GameObject letrasUsadas, palabraAcertando;

    string[] palabras = {
            "elefante", "jirafa", "computadora", "programacion", "auriculares",
            "microfono", "bicicleta", "ventilador", "automovil", "astronauta",
            "murcielago", "biblioteca", "refrigerador", "calculadora", "television",
            "parlante", "escritorio", "ventana", "colegio", "universidad",
            "examen", "diccionario", "bateria", "camara", "celular",
            "videojuego", "aplicacion", "inteligencia", "artificial", "algoritmo",
            "desarrollo", "software", "hardware", "procesador", "memoria",
            "tarjeta", "madre", "enchufe", "cable", "conector",
            "puerto", "servidor", "internet", "criptografia", "seguridad",
            "contraseña", "acceso", "usuario", "administrador", "sistema",
            "operativo", "windows", "linux", "android", "aplicacion",
            "juego", "programa", "desarrollador", "ingeniero", "tecnico",
            "analista", "consultor", "proyecto", "metodologia", "documentacion",
            "requisito", "integracion", "implementacion", "despliegue", "mantenimiento",
            "soporte", "actualizacion", "parche", "release", "arquitectura",
            "framework", "biblioteca", "interfaz", "usuario", "backend",
            "frontend", "desempeño", "optimización", "rendimiento", "simulación",
            "virtualización", "criptomoneda", "blockchain", "transacción", "encriptación",
            "decodificación", "análisis", "compilador", "interpretador", "ejecutable",
            "secuencia", "concurrencia", "paralelismo", "asincronía", "sincronización",
            "semaforo", "hilo", "proceso", "tarea", "buffer",
            "memoria", "caché", "optimización", "compresión", "decompresión"
        };
    private string palabraElegida = "hola esto es una prueba";

    private double ganadas;


    //BotonesTeclado
    public GameObject letraA, letraB, letraC, letraD, letraE, letraF, letraG, letraH, letraI, letraJ, letraK, letraL, letraM, letraN, letraNN, letraO, letraP, letraQ, letraR, letraS, letraT, letraU, letraV, letraW, letraX, letraY, letraZ;

    // Start is called before the first frame update
    void Start()
    {
        inicio.SetActive(true);
        segundo.SetActive(false);
        tercero.SetActive(false);
        cuarto.SetActive(false);
        quinto.SetActive(false);
        sexto.SetActive(false);
        septimo.SetActive(false);
        ganadas = 0;
        recuadroTeclado.SetActive(true);
        recuadroPalabra.SetActive(true);
        recuadroLetras.SetActive(true);

        palabraElegida.ToUpper();
        letrasUsadas.SetActive(true);
        palabraAcertando.SetActive(true);
        System.Console.WriteLine(letrasUsadas.GetComponents<Component>());
        letrasUsadas.GetComponent<TextMeshProUGUI>().text = "";
        palabraAcertando.GetComponent<TextMeshProUGUI>().text = "";

        FinPartida.SetActive(false);
        botonSalir.SetActive(false);
        volverJugar.SetActive(false);
        mensajeFinal.SetActive(false);

        letraA.SetActive(true);
        letraA.GetComponent<Image>().color = new Color(255, 255, 255);
        letraA.GetComponent<Button>().interactable = true;
        letraB.SetActive(true);
        letraB.GetComponent<Image>().color = new Color(255, 255, 255);
        letraC.SetActive(true);
        letraC.GetComponent<Image>().color = new Color(255, 255, 255);
        letraD.SetActive(true);
        letraD.GetComponent<Image>().color = new Color(255, 255, 255);
        letraE.SetActive(true);
        letraE.GetComponent<Image>().color = new Color(255, 255, 255);
        letraF.SetActive(true);
        letraF.GetComponent<Image>().color = new Color(255, 255, 255);
        letraG.SetActive(true);
        letraG.GetComponent<Image>().color = new Color(255, 255, 255);
        letraH.SetActive(true);
        letraH.GetComponent<Image>().color = new Color(255, 255, 255);
        letraI.SetActive(true);
        letraI.GetComponent<Image>().color = new Color(255, 255, 255);
        letraJ.SetActive(true);
        letraJ.GetComponent<Image>().color = new Color(255, 255, 255);
        letraK.SetActive(true);
        letraK.GetComponent<Image>().color = new Color(255, 255, 255);
        letraL.SetActive(true);
        letraL.GetComponent<Image>().color = new Color(255, 255, 255);
        letraM.SetActive(true);
        letraM.GetComponent<Image>().color = new Color(255, 255, 255);
        letraN.SetActive(true);
        letraN.GetComponent<Image>().color = new Color(255, 255, 255);
        letraNN.SetActive(true);
        letraNN.GetComponent<Image>().color = new Color(255, 255, 255);
        letraO.SetActive(true);
        letraO.GetComponent<Image>().color = new Color(255, 255, 255);
        letraP.SetActive(true);
        letraP.GetComponent<Image>().color = new Color(255, 255, 255);
        letraQ.SetActive(true);
        letraQ.GetComponent<Image>().color = new Color(255, 255, 255);
        letraR.SetActive(true);
        letraR.GetComponent<Image>().color = new Color(255, 255, 255);
        letraS.SetActive(true);
        letraS.GetComponent<Image>().color = new Color(255, 255, 255);
        letraT.SetActive(true);
        letraT.GetComponent<Image>().color = new Color(255, 255, 255);
        letraU.SetActive(true);
        letraU.GetComponent<Image>().color = new Color(255, 255, 255);
        letraV.SetActive(true);
        letraV.GetComponent<Image>().color = new Color(255, 255, 255);
        letraW.SetActive(true);
        letraW.GetComponent<Image>().color = new Color(255, 255, 255);
        letraX.SetActive(true);
        letraX.GetComponent<Image>().color = new Color(255, 255, 255);
        letraY.SetActive(true);
        letraY.GetComponent<Image>().color = new Color(255, 255, 255);
        letraZ.SetActive(true);
        letraZ.GetComponent<Image>().color = new Color(255, 255, 255);

        letraA.GetComponent<Button>().interactable = true;
        letraB.GetComponent<Button>().interactable = true;
        letraC.GetComponent<Button>().interactable = true;
        letraD.GetComponent<Button>().interactable = true;
        letraE.GetComponent<Button>().interactable = true;
        letraF.GetComponent<Button>().interactable = true;
        letraG.GetComponent<Button>().interactable = true;
        letraH.GetComponent<Button>().interactable = true;
        letraI.GetComponent<Button>().interactable = true;
        letraJ.GetComponent<Button>().interactable = true;
        letraK.GetComponent<Button>().interactable = true;
        letraL.GetComponent<Button>().interactable = true;
        letraM.GetComponent<Button>().interactable = true;
        letraN.GetComponent<Button>().interactable = true;
        letraNN.GetComponent<Button>().interactable = true;
        letraO.GetComponent<Button>().interactable = true;
        letraP.GetComponent<Button>().interactable = true;
        letraQ.GetComponent<Button>().interactable = true;
        letraR.GetComponent<Button>().interactable = true;
        letraS.GetComponent<Button>().interactable = true;
        letraT.GetComponent<Button>().interactable = true;
        letraU.GetComponent<Button>().interactable = true;
        letraV.GetComponent<Button>().interactable = true;
        letraW.GetComponent<Button>().interactable = true;
        letraX.GetComponent<Button>().interactable = true;
        letraY.GetComponent<Button>().interactable = true;
        letraZ.GetComponent<Button>().interactable = true;

        sacarPalabra();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void sacarPalabra()
    {
        Random rand = new Random();
        int indiceAleatorio = rand.Next(0, palabras.Length);
        string palabraAleatoria = palabras[indiceAleatorio];
        palabraElegida = palabraAleatoria;
    }
    private bool procesarLetra(char i)
    {
        bool primeraLetra = true;
        bool acertado = false;
        char[] palabraResultante;
        if (palabraAcertando.GetComponent<TextMeshProUGUI>().text.Length != 0)
            primeraLetra = false;


        palabraResultante = palabraAcertando.GetComponent<TextMeshProUGUI>().text.ToString().ToCharArray();


        for(int k = 0; k<palabraElegida.ToString().Length; k++)
        {
            char[] palabraSeparada = palabraElegida.ToUpper().ToCharArray();
            if (primeraLetra)
            {
                if (i == palabraSeparada[k])
                {
                    palabraAcertando.GetComponent<TextMeshProUGUI>().text = palabraAcertando.GetComponent<TextMeshProUGUI>().text + i;
                    acertado = true;
                }
                else if (palabraSeparada[k] != ' ')
                    palabraAcertando.GetComponent<TextMeshProUGUI>().text = palabraAcertando.GetComponent<TextMeshProUGUI>().text + "*";
                else
                    palabraAcertando.GetComponent<TextMeshProUGUI>().text = palabraAcertando.GetComponent<TextMeshProUGUI>().text + " ";
            }
            else
            {
                if (i == palabraSeparada[k])
                {
                    palabraResultante[k] = i;
                    acertado = true;
                    palabraAcertando.GetComponent<TextMeshProUGUI>().text = palabraResultante.ArrayToString();
                }
            }
        }

        letrasUsadas.GetComponent<TextMeshProUGUI>().text += " " + i;
        return acertado;
    }

    public void quitarParteCuerpo()
    {
        if (inicio.activeSelf)
        {
            inicio.SetActive(false);
            segundo.SetActive(true);
        }
        else if (segundo.activeSelf)
        {
            segundo.SetActive(false);
            tercero.SetActive(true);
        }
        else if (tercero.activeSelf)
        {
            tercero.SetActive(false);
            cuarto.SetActive(true);
        }
        else if (cuarto.activeSelf)
        {
            cuarto.SetActive(false);
            quinto.SetActive(true);
        }
        else if (quinto.activeSelf)
        {
            quinto.SetActive(false);
            sexto.SetActive(true);
        }
        else if (sexto.activeSelf)
        {
            sexto.SetActive(false);
            septimo.SetActive(true);
        }
        else
        {
            FinPartida.SetActive(true);
            botonSalir.SetActive(true);
            volverJugar.SetActive(true);
            mensajeFinal.GetComponent<TextMeshProUGUI>().text = "No has conseguido acertar la palabra :(";
            mensajeFinal.SetActive(true);

            recuadroTeclado.SetActive(false);
        }
    }

    public void comprobarPalabraAcertada()
    {
        bool acertado = true;
        char[] palabra = palabraAcertando.GetComponent<TextMeshProUGUI>().text.ToUpper().ToCharArray();
        for(int k = 0; k< palabra.Length; k++)
        {
            if (palabra[k] == '*')
            {
                acertado = false;
                break;
            }
        }

        if (acertado)
        {
            FinPartida.SetActive(true);
            botonSalir.SetActive(true);
            volverJugar.SetActive(true);
            mensajeFinal.GetComponent<TextMeshProUGUI>().text = "¡Has conseguido acertar la palabra! :)";
            mensajeFinal.SetActive(true);
            palabraAcertando.SetActive(false);
            recuadroTeclado.SetActive(false);
            recuadroPalabra.SetActive(false);
            ganadas++;
        }
    }



    public void clickLetraA()
    {
        if (procesarLetra('A'))
        {
            letraA.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraA.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraA.GetComponent<Button>().interactable = false;
    }

    public void clickLetraB()
    {
        if (procesarLetra('B'))
        {
            letraB.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraB.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraB.GetComponent<Button>().interactable = false;
    }

    public void clickLetraC()
    {
        if (procesarLetra('C'))
        {
            letraC.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraC.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraC.GetComponent<Button>().interactable = false;
    }

    public void clickLetraD()
    {
        if (procesarLetra('D'))
        {
            letraD.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraD.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraD.GetComponent<Button>().interactable = false;
    }

    public void clickLetraE()
    {
        if (procesarLetra('E'))
        {
            letraE.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraE.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraE.GetComponent<Button>().interactable = false;
    }

    public void clickLetraF()
    {
        if (procesarLetra('F'))
        {
            letraF.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraF.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraF.GetComponent<Button>().interactable = false;
    }

    public void clickLetraG()
    {
        if (procesarLetra('G'))
        {
            letraG.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraG.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraG.GetComponent<Button>().interactable = false;
    }

    public void clickLetraH()
    {
        if (procesarLetra('H'))
        {
            letraH.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraH.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraH.GetComponent<Button>().interactable = false;
    }

    public void clickLetraI()
    {
        if (procesarLetra('I'))
        {
            letraI.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraI.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraI.GetComponent<Button>().interactable = false;
    }

    public void clickLetraJ()
    {
        if (procesarLetra('J'))
        {
            letraJ.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraJ.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraJ.GetComponent<Button>().interactable = false;
    }

    public void clickLetraK()
    {
        if (procesarLetra('K'))
        {
            letraK.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraK.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraK.GetComponent<Button>().interactable = false;
    }

    public void clickLetraL()
    {
        if (procesarLetra('L'))
        {
            letraL.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraL.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraL.GetComponent<Button>().interactable = false;
    }

    public void clickLetraM()
    {
        if (procesarLetra('M'))
        {
            letraM.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraM.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraM.GetComponent<Button>().interactable = false;

    }

    public void clickLetraN()
    {
        if (procesarLetra('N'))
        {
            letraN.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraN.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraN.GetComponent<Button>().interactable = false;
    }

    public void clickLetraNN()
    {
        if (procesarLetra('Ñ'))
        {
            letraNN.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraNN.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraNN.GetComponent<Button>().interactable = false;
    }

    public void clickLetraO()
    {
        if (procesarLetra('O'))
        {
            letraO.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraO.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraO.GetComponent<Button>().interactable = false;
    }

    public void clickLetraP()
    {
        if (procesarLetra('P'))
        {
            letraP.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraP.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraP.GetComponent<Button>().interactable = false;
    }

    public void clickLetraQ()
    {
        if (procesarLetra('Q'))
        {
            letraQ.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraQ.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraQ.GetComponent<Button>().interactable = false;
    }

    public void clickLetraR()
    {
        if (procesarLetra('R'))
        {
            letraR.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraR.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraR.GetComponent<Button>().interactable = false;
    }

    public void clickLetraS()
    {
        if (procesarLetra('S'))
        {
            letraS.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraS.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraS.GetComponent<Button>().interactable = false;
    }

    public void clickLetraT()
    {
        if (procesarLetra('T'))
        {
            letraT.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraT.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraT.GetComponent<Button>().interactable = false;
    }

    public void clickLetraU()
    {
        if (procesarLetra('U'))
        {
            letraU.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraU.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraU.GetComponent<Button>().interactable = false;
    }

    public void clickLetraV()
    {
        if (procesarLetra('V'))
        {
            letraV.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraV.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraV.GetComponent<Button>().interactable = false;
    }

    public void clickLetraW()
    {
        if (procesarLetra('W'))
        {
            letraW.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraW.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraW.GetComponent<Button>().interactable = false;
    }

    public void clickLetraX()
    {
        if (procesarLetra('X'))
        {
            letraX.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraX.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraX.GetComponent<Button>().interactable = false;
    }

    public void clickLetraY()
    {
        if (procesarLetra('Y'))
        {
            letraY.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraY.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraY.GetComponent<Button>().interactable = false;
    }

    public void clickLetraZ()
    {
        if (procesarLetra('Z'))
        {
            letraZ.GetComponent<Image>().color = new Color(47, 173, 47);
            comprobarPalabraAcertada();
        }
        else
        {
            letraZ.GetComponent<Image>().color = new Color(229, 44, 55);
            quitarParteCuerpo();
        }

        letraZ.GetComponent<Button>().interactable = false;
    }

    public void clickVolverAJugar()
    {
        inicio.SetActive(true);
        segundo.SetActive(false);
        tercero.SetActive(false);
        cuarto.SetActive(false);
        quinto.SetActive(false);
        sexto.SetActive(false);
        septimo.SetActive(false);
        recuadroTeclado.SetActive(true);

        palabraElegida.ToUpper();
        letrasUsadas.SetActive(true);
        palabraAcertando.SetActive(true);
        System.Console.WriteLine(letrasUsadas.GetComponents<Component>());
        letrasUsadas.GetComponent<TextMeshProUGUI>().text = "";
        palabraAcertando.GetComponent<TextMeshProUGUI>().text = "";

        FinPartida.SetActive(false);
        botonSalir.SetActive(false);
        volverJugar.SetActive(false);
        mensajeFinal.SetActive(false);

        letraA.SetActive(true);
        letraA.GetComponent<Image>().color = new Color(255, 255, 255);
        letraA.GetComponent<Button>().interactable = true;
        letraB.SetActive(true);
        letraB.GetComponent<Image>().color = new Color(255, 255, 255);
        letraC.SetActive(true);
        letraC.GetComponent<Image>().color = new Color(255, 255, 255);
        letraD.SetActive(true);
        letraD.GetComponent<Image>().color = new Color(255, 255, 255);
        letraE.SetActive(true);
        letraE.GetComponent<Image>().color = new Color(255, 255, 255);
        letraF.SetActive(true);
        letraF.GetComponent<Image>().color = new Color(255, 255, 255);
        letraG.SetActive(true);
        letraG.GetComponent<Image>().color = new Color(255, 255, 255);
        letraH.SetActive(true);
        letraH.GetComponent<Image>().color = new Color(255, 255, 255);
        letraI.SetActive(true);
        letraI.GetComponent<Image>().color = new Color(255, 255, 255);
        letraJ.SetActive(true);
        letraJ.GetComponent<Image>().color = new Color(255, 255, 255);
        letraK.SetActive(true);
        letraK.GetComponent<Image>().color = new Color(255, 255, 255);
        letraL.SetActive(true);
        letraL.GetComponent<Image>().color = new Color(255, 255, 255);
        letraM.SetActive(true);
        letraM.GetComponent<Image>().color = new Color(255, 255, 255);
        letraN.SetActive(true);
        letraN.GetComponent<Image>().color = new Color(255, 255, 255);
        letraNN.SetActive(true);
        letraNN.GetComponent<Image>().color = new Color(255, 255, 255);
        letraO.SetActive(true);
        letraO.GetComponent<Image>().color = new Color(255, 255, 255);
        letraP.SetActive(true);
        letraP.GetComponent<Image>().color = new Color(255, 255, 255);
        letraQ.SetActive(true);
        letraQ.GetComponent<Image>().color = new Color(255, 255, 255);
        letraR.SetActive(true);
        letraR.GetComponent<Image>().color = new Color(255, 255, 255);
        letraS.SetActive(true);
        letraS.GetComponent<Image>().color = new Color(255, 255, 255);
        letraT.SetActive(true);
        letraT.GetComponent<Image>().color = new Color(255, 255, 255);
        letraU.SetActive(true);
        letraU.GetComponent<Image>().color = new Color(255, 255, 255);
        letraV.SetActive(true);
        letraV.GetComponent<Image>().color = new Color(255, 255, 255);
        letraW.SetActive(true);
        letraW.GetComponent<Image>().color = new Color(255, 255, 255);
        letraX.SetActive(true);
        letraX.GetComponent<Image>().color = new Color(255, 255, 255);
        letraY.SetActive(true);
        letraY.GetComponent<Image>().color = new Color(255, 255, 255);
        letraZ.SetActive(true);
        letraZ.GetComponent<Image>().color = new Color(255, 255, 255);

        letraA.GetComponent<Button>().interactable = true;
        letraB.GetComponent<Button>().interactable = true;
        letraC.GetComponent<Button>().interactable = true;
        letraD.GetComponent<Button>().interactable = true;
        letraE.GetComponent<Button>().interactable = true;
        letraF.GetComponent<Button>().interactable = true;
        letraG.GetComponent<Button>().interactable = true;
        letraH.GetComponent<Button>().interactable = true;
        letraI.GetComponent<Button>().interactable = true;
        letraJ.GetComponent<Button>().interactable = true;
        letraK.GetComponent<Button>().interactable = true;
        letraL.GetComponent<Button>().interactable = true;
        letraM.GetComponent<Button>().interactable = true;
        letraN.GetComponent<Button>().interactable = true;
        letraNN.GetComponent<Button>().interactable = true;
        letraO.GetComponent<Button>().interactable = true;
        letraP.GetComponent<Button>().interactable = true;
        letraQ.GetComponent<Button>().interactable = true;
        letraR.GetComponent<Button>().interactable = true;
        letraS.GetComponent<Button>().interactable = true;
        letraT.GetComponent<Button>().interactable = true;
        letraU.GetComponent<Button>().interactable = true;
        letraV.GetComponent<Button>().interactable = true;
        letraW.GetComponent<Button>().interactable = true;
        letraX.GetComponent<Button>().interactable = true;
        letraY.GetComponent<Button>().interactable = true;
        letraZ.GetComponent<Button>().interactable = true;
    }

    public void clickSalir()
    {
        //Implementar monedas y barras de estado

        SceneManager.LoadScene("Jardin");
    }
}
