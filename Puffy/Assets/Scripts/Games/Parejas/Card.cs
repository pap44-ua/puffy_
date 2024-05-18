using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Card : MonoBehaviour
{
    public Sprite frontImage; // Imagen de la parte frontal de la carta
    public Sprite backImage; // Imagen de la parte trasera de la carta
    public static int volteadas = 0; // Número de cartas volteadas
    public static Card carta1; // Primera carta volteada
    public static Card carta2; // Segunda carta volteada
    public static bool voltearCartas = false; // Indica si se deben voltear las cartas
    public GameObject Atras;
    public GameObject Reiniciar;
    public static int pares = 0; // Número de pares adivinados
    private SpriteRenderer spriteRenderer;

    public List<Sprite> finalImages;

    private bool abajo = false; // Indica si la carta está volteada
    private bool adivinada = false; // Indica si la carta ya fue adivinada

    public AudioClip flipSound; // Sonido de volteo de cartas
    public AudioSource audioSource;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = gameObject.AddComponent<AudioSource>();
        Flip(); // Voltea la carta al inicio para mostrar su parte trasera
        abajo = true;

        finalImages = new List<Sprite>();
        finalImages.Add(Resources.Load<Sprite>("F1")); //Cuadro
        finalImages.Add(Resources.Load<Sprite>("F2")); //Victoria
        finalImages.Add(Resources.Load<Sprite>("F3")); //Atras
        finalImages.Add(Resources.Load<Sprite>("F4")); //Reiniciar

        flipSound = Resources.Load<AudioClip>("cartas");
        audioSource.clip = flipSound;

    }

    void OnMouseDown()
    {
        if (voltearCartas)
        {
            VoltearCartas();
        }
        else if (gameObject == Atras)
        {
            Debug.Log("atras");
            SceneManager.LoadScene("Jardin");
        }
        else if (gameObject == Reiniciar)
        {
            Debug.Log("reiniciar");
            SceneManager.LoadScene("Parejas");
        }
        else
        {
            Flip();
        }

    }

    public void Flip()
    {
        if (!adivinada)
        {
            if (abajo)
            {

                if (volteadas == 0)
                {
                    volteadas++;
                    carta1 = this;
                    spriteRenderer.sprite = frontImage;
                    PlayFlipSound();
                    abajo = false;
                }
                else if (volteadas == 1)
                {
                    carta2 = this;
                    spriteRenderer.sprite = frontImage;
                    PlayFlipSound();
                    abajo = false;


                    if (carta1.frontImage == carta2.frontImage)
                    {
                        pares++;
                        carta1.adivinada = true;
                        carta2.adivinada = true;
                        carta1 = null;
                        carta2 = null;
                        volteadas = 0;

                    }
                    else
                    {
                        voltearCartas = true;
                        volteadas = 0;
                    }
                }
                else
                {
                    spriteRenderer.sprite = backImage;
                }

            }
            else
            {
                spriteRenderer.sprite = backImage;
                abajo = true;
            }
            Debug.Log(pares);

            if (pares == 10)
            {
                final();
            }
        }
    }

    public void VoltearCartas()
    {
        carta1.Flip();
        carta2.Flip();

        carta1 = null;
        carta2 = null;

        voltearCartas = false;
    }

    private void PlayFlipSound()
    {
        if (flipSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(flipSound);
        }
    }

    public void final()
    {

        Sprite spriteACrear = finalImages[0];
        GameObject fin = new GameObject("Cuadro");
        SpriteRenderer spriteRenderer = fin.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = spriteACrear;
        spriteRenderer.sortingOrder = 4;
        fin.transform.localScale = new Vector3(0.11f, 0.17f, 1f);

        Sprite spriteACrear2 = finalImages[1];
        GameObject victoria = new GameObject("Victoria");
        SpriteRenderer spriteRenderer2 = victoria.AddComponent<SpriteRenderer>();
        spriteRenderer2.sprite = spriteACrear2;
        spriteRenderer2.sortingOrder = 5;
        victoria.transform.localScale = new Vector3(0.46f, 0.46f, 1f);
        victoria.transform.position = new Vector3(0f, 0.881f, 0f);

        Sprite spriteACrear3 = finalImages[2];
        GameObject atras = new GameObject("Atras");
        SpriteRenderer spriteRenderer3 = atras.AddComponent<SpriteRenderer>();
        spriteRenderer3.sprite = spriteACrear3;
        spriteRenderer3.sortingOrder = 5;
        atras.transform.localScale = new Vector3(0.31f, 0.31f, 1f);
        atras.transform.position = new Vector3(0f, -0.6f, 0f);
        // Añade un BoxCollider2D y ajusta su tamaño según el tamaño de la imagen
        BoxCollider2D collider = atras.AddComponent<BoxCollider2D>();
        collider.size = new Vector2(4.08f, 2f); // Tamaño del collider

        atras.AddComponent<Final>();
        GameObject Atras = atras;

        Sprite spriteACrear4 = finalImages[3];
        GameObject reiniciar = new GameObject("Reiniciar");
        SpriteRenderer spriteRenderer4 = reiniciar.AddComponent<SpriteRenderer>();
        spriteRenderer4.sprite = spriteACrear4;
        spriteRenderer4.sortingOrder = 5;
        reiniciar.transform.localScale = new Vector3(0.31f, 0.31f, 1f);
        reiniciar.transform.position = new Vector3(0f, 0.13f, 0f);
        // Añade un BoxCollider2D y ajusta su tamaño según el tamaño de la imagen
        BoxCollider2D collider2 = reiniciar.AddComponent<BoxCollider2D>();
        collider2.size = new Vector2(4.08f, 2f); // Tamaño del collider
        reiniciar.AddComponent<Final>();
        GameObject Reiniciar = reiniciar;
    }
}
