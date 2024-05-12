using UnityEngine;

public class apareceCacaPequeña : MonoBehaviour
{
    public GameObject[] sprites;
    public LinearIndicator salud;

    private bool[] estadosSprites; // Almacena el estado actual de los sprites

    void Start()
    {
        // Inicializar el array de estadosSprites con el estado actual de los sprites
        estadosSprites = new bool[sprites.Length];
        for (int i = 0; i < sprites.Length; i++)
        {
            estadosSprites[i] = sprites[i].activeSelf;
        }
    }

    void Update()
    {
        // Si el estado actual de cada sprite coincide con el estado que deseas establecer, no lo cambies
        if (salud.GetValue() <= 10 && !estadosSprites[3])
        {
            sprites[3].SetActive(true);
            estadosSprites[3] = true;
        }
        else if (salud.GetValue() > 10 && estadosSprites[3])
        {
            sprites[3].SetActive(false);
            estadosSprites[3] = false;
        }

        if (salud.GetValue() <= 25 && !estadosSprites[2])
        {
            sprites[2].SetActive(true);
            estadosSprites[2] = true;
        }
        else if (salud.GetValue() > 25 && estadosSprites[2])
        {
            sprites[2].SetActive(false);
            estadosSprites[2] = false;
        }

        if (salud.GetValue() <= 40 && !estadosSprites[1])
        {
            sprites[1].SetActive(true);
            estadosSprites[1] = true;
        }
        else if (salud.GetValue() > 40 && estadosSprites[1])
        {
            sprites[1].SetActive(false);
            estadosSprites[1] = false;
        }

        if (salud.GetValue() <= 50 && !estadosSprites[0])
        {
            sprites[0].SetActive(true);
            estadosSprites[0] = true;
        }
        else if (salud.GetValue() > 50 && estadosSprites[0])
        {
            sprites[0].SetActive(false);
            estadosSprites[0] = false;
        }
    }
}
