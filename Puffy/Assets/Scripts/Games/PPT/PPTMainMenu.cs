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
    public GameObject tijerasImage1;
    public GameObject papelImage1;
    public GameObject piedraImage1;
    public GameObject victoria;
    public GameObject derrota;
    public GameObject empate;

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
        tijerasImage1.SetActive(false);
        papelImage1.SetActive(false);
        piedraImage1.SetActive(false);
        victoria.SetActive(false);
        derrota.SetActive(false);
        empate.SetActive(false);
    }
}
