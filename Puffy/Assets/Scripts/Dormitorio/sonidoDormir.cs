using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidoDormir : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public IEnumerator Durmiendo(){
        gameObject.GetComponent<Animator>().SetBool("durmiendo",true);
         if (audioSource != null)
        {
            audioSource.Play(); 
        }
        yield return new WaitForSeconds(1f);
        gameObject.GetComponent<Animator>().SetBool("durmiendo",false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
