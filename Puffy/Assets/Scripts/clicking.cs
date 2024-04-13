using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.SceneManagement;

public class clicking : MonoBehaviour
{
    

    private void OnMouseDown()
    {
        SceneManager.LoadScene("Tienda");
        Debug.Log("SI VA");
    }
}
