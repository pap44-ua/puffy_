using UnityEngine;

public class Card : MonoBehaviour
{
    public Sprite frontImage; // Imagen de la parte frontal de la carta
    public Sprite backImage; // Imagen de la parte trasera de la carta

    private SpriteRenderer spriteRenderer;
    private bool isFlipped = false;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = backImage; // La carta inicia con la imagen trasera
    }

    private void OnMouseDown()
    {
        if (!isFlipped)
        {
            FlipCard();
            isFlipped = true;
        }
    }

    public void FlipCard()
    {
        if (spriteRenderer.sprite == backImage)
        {
            spriteRenderer.sprite = frontImage;
        }
        else
        {
            spriteRenderer.sprite = backImage;
        }
    }
}
