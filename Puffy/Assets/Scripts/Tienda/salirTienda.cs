using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;


public class salirTienda : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        string nombreEscenaAnterior = PlayerPrefs.GetString("EscenaAnterior");

        SceneManager.LoadScene(nombreEscenaAnterior);
        Debug.Log("Va?");
    }
}
