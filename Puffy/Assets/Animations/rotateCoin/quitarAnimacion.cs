using UnityEngine;

public class quitarAnimacion : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // Si la animación está en curso y ha llegado al final
        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1f)
        {
            StopAnimation();
        }
    }

    // Función para detener la animación
    private void StopAnimation()
    {
        animator.enabled = false; // Desactiva el Animator
        Destroy(this.gameObject, 0.1f); // Destruye el objeto después de un pequeño retraso
    }
}