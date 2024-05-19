using UnityEngine;

public class beber : MonoBehaviour
{
    public GameObject moneda;
    private Animator monedaAnimator;
    public GameObject bocabuena;
    public LinearIndicator diversion;
    public LinearIndicator salud;
    public LinearIndicator comida;
    public LinearIndicator energia;
    public AudioSource audioUwU;


    void Start()
    {
    
        moneda.SetActive(false);

    }

    public void OnMouseDown()
    {
        bocabuena.SetActive(false);
        // Activa la moneda
        moneda.SetActive(true);

        if(audioUwU!=null)
        {
            audioUwU.Play();
            Debug.Log("huh?");
        }
        else
        {
            Debug.Log("UWUUUUUUUUUUUUU");
        }

       
        this.gameObject.SetActive(false);
        switch (gameObject.name)
        {
            case "pocionDiversion":
                diversion.SetValue(diversion.GetValue() + 25);
                break;
            case "pocionSalud":
                salud.SetValue(salud.GetValue() + 25);
                break;
            case "pocionComida":
                comida.SetValue(comida.GetValue() + 25);
                break;
            case "pocionEnergia":
                energia.SetValue(energia.GetValue() + 25);
                break;
        }

    }


    private void DesactivarMoneda()
    {
        bocabuena.SetActive(true);
        moneda.SetActive(false);
    }

    void Update()
    {
        
    }
}
