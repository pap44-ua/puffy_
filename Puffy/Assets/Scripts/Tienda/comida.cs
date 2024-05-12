using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comida : MonoBehaviour
{
    public GameObject activar;
    public GameObject activar2;
    public GameObject activar3;
    // Start is called before the first frame update
    void Start()
    {
        activar.SetActive(false);
        activar2.SetActive(false);
        activar3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
