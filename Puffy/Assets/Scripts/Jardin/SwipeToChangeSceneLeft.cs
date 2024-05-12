using UnityEngine;
using UnityEngine.SceneManagement;

public class SwipeToChangeSceneJardin : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("Baño");
    }
}
