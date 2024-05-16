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

    // Start is called before the first frame update
    void Start()
    {
        // Desactiva la moneda al inicio del juego
        moneda.SetActive(false);

        // Obtén el componente Animator de la moneda
        //monedaAnimator = moneda.GetComponent<Animator>();
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

        // Si hay un Animator adjunto a la moneda, inicia la animación
        /*if (monedaAnimator != null)
        {
            monedaAnimator.Play("rotateCoin", 0, 0); // Reemplaza "rotateCoin" con el nombre de tu animación
        }*/

        // Desactiva la moneda después de un retraso de 2 segundos
        //Invoke("DesactivarMoneda", 1f);
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

    // Método para desactivar la moneda
    private void DesactivarMoneda()
    {
        bocabuena.SetActive(true);
        moneda.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
