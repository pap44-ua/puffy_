using UnityEngine;
using UnityEngine.SceneManagement;

public class SwipeToChangeScene : MonoBehaviour
{
    private Vector2 fingerDownPosition;
    private Vector2 fingerUpPosition;

    [SerializeField]
    private bool detectSwipeOnlyAfterRelease = false;

    [SerializeField]
    private float minDistanceForSwipe = 20f;

    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                fingerUpPosition = touch.position;
                fingerDownPosition = touch.position;
            }

            if (!detectSwipeOnlyAfterRelease && touch.phase == TouchPhase.Moved)
            {
                fingerDownPosition = touch.position;
                DetectSwipe();
            }

            if (touch.phase == TouchPhase.Ended)
            {
                fingerDownPosition = touch.position;
                DetectSwipe();
            }
        }
    }

    void DetectSwipe()
    {
        if (Vector2.Distance(fingerDownPosition, fingerUpPosition) >= minDistanceForSwipe)
        {
            Vector2 direction = fingerUpPosition - fingerDownPosition;
            if (direction.x > 0 && Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
            {
                Debug.Log("Right Swipe");
                // Cambia a la escena "Cocina" solo si el gesto es hacia la derecha
                SceneManager.LoadScene("Cocina");
            }
            else if (direction.x < 0 && Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
            {
                Debug.Log("Left Swipe");
                // Aquí puedes manejar el gesto hacia la izquierda si es necesario
            }
            else if (direction.y > 0 && Mathf.Abs(direction.y) > Mathf.Abs(direction.x))
            {
                Debug.Log("Up Swipe");
                // Aquí puedes manejar el gesto hacia arriba si es necesario
            }
            else if (direction.y < 0 && Mathf.Abs(direction.y) > Mathf.Abs(direction.x))
            {
                Debug.Log("Down Swipe");
                // Aquí puedes manejar el gesto hacia abajo si es necesario
            }

            fingerUpPosition = fingerDownPosition;
        }
    }
}
