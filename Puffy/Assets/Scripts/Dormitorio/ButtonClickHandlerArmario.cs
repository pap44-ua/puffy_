using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ButtonClickHandlerArmario : MonoBehaviour
{
    public GameObject canvasArmario;
    public void OnMouseDown()
    {
        canvasArmario.SetActive(false);
        
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
