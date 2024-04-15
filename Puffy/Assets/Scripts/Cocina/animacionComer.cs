using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacionComer : MonoBehaviour
{
    public AudioSource audioSource;
    public LinearIndicator comida;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public IEnumerator Comiendo(){
        comida.SetValue(comida.GetValue()+25);
        gameObject.GetComponent<Animator>().SetBool("comiendo",true);
         if (audioSource != null)
        {
            audioSource.Play(); 
        }
        yield return new WaitForSeconds(1f);
        gameObject.GetComponent<Animator>().SetBool("comiendo",false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
