using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.SceneManagement;

public class clicking : MonoBehaviour
{
    

    private void OnMouseDown()
    {
        PlayerPrefs.SetString("EscenaAnterior", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Tienda");
        Debug.Log("SI VA");
    }
}
