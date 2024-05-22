using System.Collections.Generic;
using System.Collections;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ElementoScript : MonoBehaviour
{
    public GameObject eligeText;
    public GameObject papelButton;
    public GameObject tijerasButton;
    public GameObject piedraButton;
    public GameObject vsText;
    public GameObject tijerasImage;
    public GameObject piedraImage;
    public GameObject papelImage;
    public GameObject tijerasImage1;
    public GameObject piedraImage1;
    public GameObject papelImage1;
    public GameObject victoria;
    public GameObject derrota;
    public GameObject empate;
    public GameObject jugarButton;
    public GameObject volverButton;

    public AudioSource audioSource;
    public AudioClip victoriaClip;
    public AudioClip derrotaClip;

    public int money;

    void Start(){
        money = PlayerPrefs.GetInt("Coins",0);
    }
    void OnMouseDown()
    {
        if(gameObject == jugarButton){
            victoria.SetActive(false);
            derrota.SetActive(false);
            empate.SetActive(false);
            jugarButton.SetActive(false);
            volverButton.SetActive(false);
            piedraImage.SetActive(false);
            papelImage.SetActive(false);
            tijerasImage.SetActive(false);
            piedraImage1.SetActive(false);
            papelImage1.SetActive(false);
            tijerasImage1.SetActive(false);
            vsText.SetActive(false);
            eligeText.SetActive(true);
            piedraButton.SetActive(true);
            papelButton.SetActive(true);
            tijerasButton.SetActive(true);
        
        }
        else if(gameObject == volverButton){
            SceneManager.LoadScene("Jardin");
        }
        else{
            StartCoroutine(ProcesoJuego());

            eligeText.SetActive(false);
            piedraButton.SetActive(false);
            papelButton.SetActive(false);
            tijerasButton.SetActive(false);
        }
        

        
    }

    IEnumerator ProcesoJuego()
    {
        // Activa los nuevos elementos correspondientes a este elemento
        SeleccionJugador();

        // Mostrar el texto vs
        vsText.SetActive(true);

        SeleccionMaquina();

        DeterminarResultado();

        jugarButton.SetActive(true);
        volverButton.SetActive(true);

        yield return null;
    }

    void SeleccionJugador()
    {
        
        // Implementa la l�gica espec�fica para cada elemento
        if (gameObject == piedraButton)
        {
            piedraImage.SetActive(true);
        }
        else if (gameObject == papelButton)
        {
            papelImage.SetActive(true);
        }
        else
        {
            tijerasImage.SetActive(true);
        }
    }

    void SeleccionMaquina()
    {
        int eleccion = Random.Range(0, 3);

        if (eleccion == 0)
        {
            piedraImage1.SetActive(true);
        }
        else if (eleccion == 1)
        {
            papelImage1.SetActive(true);
        }
        else
        {
            tijerasImage1.SetActive(true);
        }
    }
    
    void DeterminarResultado()
    {
        // Obtener las selecciones del jugador y de la máquina
        bool jugadorPiedra = piedraImage.activeSelf;
        bool jugadorPapel = papelImage.activeSelf;
        bool jugadorTijeras = tijerasImage.activeSelf;

        bool maquinaPiedra = piedraImage1.activeSelf;
        bool maquinaPapel = papelImage1.activeSelf;
        bool maquinaTijeras = tijerasImage1.activeSelf;

        // Determinar el resultado
        if ((jugadorPiedra && maquinaTijeras) || (jugadorPapel && maquinaPiedra) || (jugadorTijeras && maquinaPapel))
        {   
            money = money + 10;
            PlayerPrefs.SetInt("Coins", money);
            victoria.SetActive(true);
            audioSource.PlayOneShot(victoriaClip);
        }
        else if ((jugadorPiedra && maquinaPapel) || (jugadorPapel && maquinaTijeras) || (jugadorTijeras && maquinaPiedra))
        {
            derrota.SetActive(true);
            audioSource.PlayOneShot(derrotaClip);
        }
        else
        {
            empate.SetActive(true);
        }
    }
    
}
