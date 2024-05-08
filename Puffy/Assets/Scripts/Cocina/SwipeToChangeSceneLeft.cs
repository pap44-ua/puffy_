using UnityEngine;
using UnityEngine.SceneManagement;

public class SwipeToChangeSceneCocina : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("Dormitorio");
    }
}
