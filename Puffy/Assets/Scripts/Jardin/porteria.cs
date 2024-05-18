using UnityEngine;

public class porteria : MonoBehaviour
{
    private int coins;
    public AudioSource sonido;

    void Start()
    {
        coins = PlayerPrefs.GetInt("Coins",0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Pelota"))
        {
            if(sonido != null)
            {
                sonido.Play();
            }
            coins = coins + 1;
            // Muestra "GOOOOLL" en la consola
            Debug.Log("monedas: " + coins);
        }
    }

    void update()
    {

        PlayerPrefs.SetInt("Coins", coins);

    }
}
