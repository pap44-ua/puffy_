using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PPTMainMenu : MonoBehaviour
{
    public GameObject playButton;
    public GameObject jugamosText;
    public GameObject eligeText;
    public GameObject papelButton;
    public GameObject tijerasButton;
    public GameObject piedraButton;
    public GameObject vsText;
    public GameObject tijerasImage;
    public GameObject papelImage;
    public GameObject piedraImage;

    void Start()
    {
        papelButton.SetActive(false);
        tijerasButton.SetActive(false);
        piedraButton.SetActive(false);
        eligeText.SetActive(false);
        vsText.SetActive(false);
        tijerasImage.SetActive(false);
        papelImage.SetActive(false);
        piedraImage.SetActive(false);
    }

    public void OnPlayButtonClick()
    {
        Debug.Log("Botón Play presionado");
        // Desactiva los elementos existentes
        playButton.SetActive(false);
        jugamosText.SetActive(false);

        // Activa los nuevos elementos
        eligeText.SetActive(true);
        piedraButton.SetActive(true);
        papelButton.SetActive(true);
        tijerasButton.SetActive(true);
    }
}
