using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickHandlerJuegos : MonoBehaviour
{
    public GameObject canvasJuegos;
    public void OnMouseDown()
    {
        canvasJuegos.SetActive(false);

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
