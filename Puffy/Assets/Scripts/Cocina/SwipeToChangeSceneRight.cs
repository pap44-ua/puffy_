using UnityEngine;
using UnityEngine.SceneManagement;

public class SwipeToChangeSceneRightCocina : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("Baño");
    }
}
