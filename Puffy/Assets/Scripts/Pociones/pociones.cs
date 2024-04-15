using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pociones : MonoBehaviour
{

     public GameObject armario;
     

    public void activeNevera()
    {
        armario.SetActive(true);
    }

    public void OnMouseDown()
    {
        activeNevera();
    }
    // Start is called before the first frame update
    void Start()
    {
        armario.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
