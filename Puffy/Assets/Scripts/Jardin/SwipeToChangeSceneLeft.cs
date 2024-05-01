using UnityEngine;
using UnityEngine.SceneManagement;

public class SwipeToChangeSceneJardin : MonoBehaviour
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
            if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
            {
            
                Debug.Log("Left Swipe");
                // Cambia a la escena anterior, o maneja como desees
                SceneManager.LoadScene("Baño");
                
            }
            /*else
            {
                if (direction.y > 0)
                {
                    Debug.Log("Up Swipe");
                    // Maneja el deslizamiento hacia arriba si es necesario
                }
                else
                {
                    Debug.Log("Down Swipe");
                    // Maneja el deslizamiento hacia abajo si es necesario
                }
            }*/
            fingerUpPosition = fingerDownPosition;
        }
    }
}
