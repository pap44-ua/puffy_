using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tamanyo : MonoBehaviour
{
    public Camera mainCamera;
    public float referenciaTamanyo = 5f;
    // Start is called before the first frame update
    void Start()
    {
        float tamanyoOrto = mainCamera.orthographicSize;

        float escala=referenciaTamanyo / tamanyoOrto;

        transform.localScale = new Vector3(escala, 2f, 1f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
