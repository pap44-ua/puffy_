using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
    

public class Parejas_MM : MonoBehaviour
{
    public GameObject playButton;
    public GameObject jugamosText;
    public GameObject tablero;
    public int rows = 4; // Número de filas
    public int columns = 5; // Número de columnas
    public float cardSpacing = 1.25f; // Espaciado entre las cartas

    public List<Sprite> cardImages; // Lista de imágenes de las cartas

    void Start()
    {
        cardImages = new List<Sprite>();
        cardImages.Add(Resources.Load<Sprite>("C1"));
        cardImages.Add(Resources.Load<Sprite>("C2"));
        cardImages.Add(Resources.Load<Sprite>("C3"));
        cardImages.Add(Resources.Load<Sprite>("C4"));
        cardImages.Add(Resources.Load<Sprite>("C5"));
        cardImages.Add(Resources.Load<Sprite>("C6"));
        cardImages.Add(Resources.Load<Sprite>("C7"));
        cardImages.Add(Resources.Load<Sprite>("C8"));
        cardImages.Add(Resources.Load<Sprite>("C9"));
        cardImages.Add(Resources.Load<Sprite>("C10"));
        cardImages.Add(Resources.Load<Sprite>("C11"));
    }

    void OnMouseDown()
    {
        if (gameObject == playButton)
        {

            jugamosText.SetActive(false);
            playButton.SetActive(false);
            tablero.SetActive(true);

            List<GameObject> cardPairs = new List<GameObject>(); // Lista de pares de cartas

            for(int j = 0; j < 2; j++){
                for(int i = 0; i < cardImages.Count - 1; i++)
                {   
                    Sprite spriteACrear = cardImages[i];
                    GameObject card = new GameObject("Carta");
                    SpriteRenderer spriteRenderer = card.AddComponent<SpriteRenderer>();
                    spriteRenderer.sprite = spriteACrear;
                    spriteRenderer.sortingOrder = 3;
                    card.transform.localScale = new Vector3(0.25f, 0.25f, 1f);

                    // Añade un BoxCollider2D y ajusta su tamaño según el tamaño de la imagen
                    BoxCollider2D collider = card.AddComponent<BoxCollider2D>();
                    collider.size = new Vector2(2.65f, 4f); // Tamaño del collider

                    Card cardComponent = card.AddComponent<Card>();
                    cardComponent.frontImage = cardImages[i];
                    cardComponent.backImage = cardImages[cardImages.Count - 1]; // Imagen de la parte trasera de la carta
                    cardPairs.Add(card);
                }
            }

            // Baraja las cartas
            ShuffleCards(cardPairs);

            // Calcular el tamaño total de la tabla
            float totalWidth = columns * cardSpacing;
            float totalHeight = rows * cardSpacing;

            // Calcular la posición inicial para centrar la tabla
            float startX = -totalWidth / 2f + cardSpacing / 2f + 0.6f;
            float startY = totalHeight / 2f - cardSpacing / 2f - 0.35f;

            // Asigna posiciones aleatorias a las cartas
            int index = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {   
                    GameObject card = cardPairs[index];
                    float xPos = startX + col * cardSpacing / 1.5f;
                    float yPos = startY - row * cardSpacing;
                    card.transform.position = new Vector3(xPos, yPos, 0);
                    index++;
                }
            }
        }


    }

    void Shuffle<T>(List<T> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            T temp = list[i];
            int randomIndex = Random.Range(i, list.Count);
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }

    void ShuffleCards(List<GameObject> cards)
    {
        for (int i = 0; i < cards.Count; i++)
        {
            GameObject temp = cards[i];
            int randomIndex = Random.Range(i, cards.Count);
            cards[i] = cards[randomIndex];
            cards[randomIndex] = temp;
        }
    }
    

    
}
