using UnityEngine;
using UnityEngine.SceneManagement;

public class SwipeToChangeSceneRight : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("Jardin");
    }
}
