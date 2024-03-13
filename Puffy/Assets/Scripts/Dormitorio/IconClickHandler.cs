using UnityEngine;
using UnityEngine.UI;

public class IconClickHandler : MonoBehaviour
{
    public Sprite normalSprite; // Sprite del fondo normal
    public Sprite squareSprite; // Sprite del Square
    private bool isNormal = true; // Variable para controlar el estado actual
    private Image backgroundImage; // Referencia al componente Image del elemento de interfaz de usuario

    void Start()
    {
        backgroundImage = GetComponent<Image>(); // Obtener el componente Image
    }

    public void OnIconClick()
    {
        if (isNormal)
        {
            // Cambiar el sprite al Square y actualizar el estado
            backgroundImage.sprite = squareSprite;
            isNormal = false;
        }
        else
        {
            // Cambiar el sprite al fondo normal y actualizar el estado
            backgroundImage.sprite = normalSprite;
            isNormal = true;
        }
    }
}
