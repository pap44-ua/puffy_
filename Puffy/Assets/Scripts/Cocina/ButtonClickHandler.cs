using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour
{
    public GameObject canvasNevera;
    public void OnClick()
    {
        canvasNevera.SetActive(!canvasNevera.activeSelf);
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
