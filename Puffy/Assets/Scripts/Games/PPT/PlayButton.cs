using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public GameObject playButton;
    public GameObject jugamosText;
    public GameObject eligeText;
    public GameObject papelButton;
    public GameObject tijerasButton;
    public GameObject piedraButton;
    public GameObject vsText;
    public GameObject tijerasImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        playButton.SetActive(false);
        jugamosText.SetActive(false);

        eligeText.SetActive(true);
        papelButton.SetActive(true);
        tijerasButton.SetActive(true);
        piedraButton.SetActive(true);
    }
}
