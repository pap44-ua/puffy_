using System.Collections.Generic;
using UnityEngine;

public class Parejas_MM : MonoBehaviour
{
    public GameObject playButton;
    public GameObject jugamosText;
    public GameObject tablero;

    public int rows = 4; // Número de filas
    public int columns = 5; // Número de columnas
    public float cardSpacing = 2f; // Espaciado entre las cartas

    public List<Sprite> cardImages; // Lista de imágenes de las cartas

    void Start()
    {
        tablero.SetActive(false);

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
    }

    void OnMouseDown()
    {
        if (gameObject == playButton)
        {
            jugamosText.SetActive(false);
            tablero.SetActive(true);
            playButton.SetActive(false);

            //Debug.Log(cardImages.Count);

            List<GameObject> cardPairs = new List<GameObject>(); // Lista de pares de cartas

            // Duplica las imágenes de las cartas
            List<Sprite> duplicatedImages = new List<Sprite>();

            foreach (Sprite image in cardImages)
            {
                duplicatedImages.Add(image);
                duplicatedImages.Add(image); // Añade la misma imagen una vez más
            }

            
            // Baraja las imágenes de las cartas
            Shuffle(duplicatedImages);

            // Crea los pares de cartas
            for (int i = 0; i < duplicatedImages.Count; i++)
            {
                // Crea un nuevo GameObject para cada carta y añade el componente Card
                GameObject card = new GameObject("Carta");
                card.AddComponent<SpriteRenderer>();
                Card cardComponent = card.AddComponent<Card>();
                cardComponent.backImage = Resources.Load<Sprite>("Reverso");
                cardComponent.frontImage = duplicatedImages[i];
                cardPairs.Add(card);
            }

            Debug.Log(cardPairs.Count);
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
        else
        {
            Debug.Log("No se ha encontrado el juego");
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
