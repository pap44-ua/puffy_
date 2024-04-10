using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class AbrirArmario : MonoBehaviour
{
    public GameObject canvasArmario;
    public void OnClick()
    {
        canvasArmario.SetActive(!canvasArmario.activeSelf);
        
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
