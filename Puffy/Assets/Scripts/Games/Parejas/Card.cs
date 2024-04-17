using UnityEngine;
using System.Collections;
using System.Threading;

public class Card : MonoBehaviour
{
    public Sprite frontImage; // Imagen de la parte frontal de la carta
    public Sprite backImage; // Imagen de la parte trasera de la carta
    public static int volteadas = 0; // Número de cartas volteadas
    public static Card carta1; // Primera carta volteada
    public static Card carta2; // Segunda carta volteada
    public static bool voltearCartas = false; // Indica si se deben voltear las cartas
    private SpriteRenderer spriteRenderer;

    private bool abajo = false; // Indica si la carta está volteada

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Flip(); // Voltea la carta al inicio para mostrar su parte trasera
        abajo = true;
    }

    void OnMouseDown()
    {
        
        if(voltearCartas)
        {
            VoltearCartas();
        }
        else{
            Flip();
        }
        
    }

    public void Flip()
    {
        if (abajo)
        {   
            if(volteadas == 0)
            {
                volteadas++;
                carta1 = this;
                spriteRenderer.sprite = frontImage;
                abajo = false;
            }
            else if(volteadas == 1)
            {
                carta2 = this;
                spriteRenderer.sprite = frontImage;
                abajo = false;
                

                if(carta1.frontImage == carta2.frontImage)
                {
                    Debug.Log("Son iguales");
                    carta1 = null;
                    carta2 = null;
                    volteadas = 0;
                }
                else
                {   
                    Debug.Log("No son iguales");
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
    }

    public void VoltearCartas()
    {   
        
        carta1.Flip();
        carta2.Flip();
        
        carta1 = null;
        carta2 = null;

        voltearCartas = false;
    }
}
