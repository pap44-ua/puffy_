using UnityEngine;
using UnityEngine.SceneManagement;

public class SwipeToChangeSceneCuracion : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("Jardin");
    }
}
