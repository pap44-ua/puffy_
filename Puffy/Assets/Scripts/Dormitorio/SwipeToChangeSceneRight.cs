using UnityEngine;
using UnityEngine.SceneManagement;

public class SwipeToChangeSceneRightDorm : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("Cocina");
    }
}
