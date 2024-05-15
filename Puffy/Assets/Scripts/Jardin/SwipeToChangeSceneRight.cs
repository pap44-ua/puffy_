using UnityEngine;
using UnityEngine.SceneManagement;

public class SwipeToChangeSceneRightJardin : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("Curacion");
    }
}
