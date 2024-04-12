using UnityEngine;

public class beber : MonoBehaviour
{
    public GameObject moneda;
    private Animator monedaAnimator;

    // Start is called before the first frame update
    void Start()
    {
        // Desactiva la moneda al inicio del juego
        moneda.SetActive(false);

        // Obtén el componente Animator de la moneda
        monedaAnimator = moneda.GetComponent<Animator>();
    }

    public void OnMouseDown()
    {
        // Activa la moneda
        moneda.SetActive(true);

        // Si hay un Animator adjunto a la moneda, inicia la animación
        if (monedaAnimator != null)
        {
            monedaAnimator.Play("rotateCoin", 0, 0); // Reemplaza "rotateCoin" con el nombre de tu animación
        }

        // Desactiva la moneda después de un retraso de 2 segundos
        Invoke("DesactivarMoneda", 1f);
        this.gameObject.SetActive(false);
    }

    // Método para desactivar la moneda
    private void DesactivarMoneda()
    {
        moneda.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
