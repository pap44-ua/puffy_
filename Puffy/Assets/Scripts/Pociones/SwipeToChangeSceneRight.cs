using UnityEngine;
using UnityEngine.SceneManagement;

public class SwipeToChangeSceneRightCuracion : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("Dormitorio");
    }
}
