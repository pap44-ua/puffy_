using System.Collections.Generic;
using UnityEngine;

public class MemoryGameController : MonoBehaviour
{
    public GameObject cardPrefab; // Prefab de la carta
    public int rows = 4; // Número de filas
    public int columns = 5; // Número de columnas
    public float cardSpacing = 2f; // Espaciado entre las cartas

    void Start()
    {
        // Lista de pares de cartas
        List<GameObject> cardPairs = new List<GameObject>();

        // Crea los pares de cartas
        for (int i = 0; i < (rows * columns) / 2; i++)
        {
            cardPairs.Add(Instantiate(cardPrefab));
            cardPairs.Add(Instantiate(cardPrefab));
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
                float xPos = startX + col * cardSpacing/1.5f;
                float yPos = startY - row * cardSpacing;
                card.transform.position = new Vector3(xPos, yPos, 0);
                index++;
            }
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
