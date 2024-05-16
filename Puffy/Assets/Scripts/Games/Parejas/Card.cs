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
    public static int pares = 0; // Número de pares adivinados
    private SpriteRenderer spriteRenderer;

    private bool abajo = false; // Indica si la carta está volteada
    private bool adivinada = false; // Indica si la carta ya fue adivinada

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
        if(!adivinada){
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
