using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TijerasScript : MonoBehaviour
{
    public GameObject playButton;
    public GameObject jugamosText;
    public GameObject eligeText;
    public GameObject papelButton;
    public GameObject tijerasButton;
    public GameObject piedraButton;
    public GameObject vsText;
    public GameObject tijerasImage;

    void OnMouseDown()
    {
        // Activa los nuevos elementos
        eligeText.SetActive(false);
        piedraButton.SetActive(false);
        papelButton.SetActive(false);
        tijerasButton.SetActive(false);

        tijerasImage.SetActive(true);
        vsText.SetActive(true);
    }
}
