using UnityEngine;
using UnityEngine.SceneManagement;

public class SwipeToChangeSceneDorm : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("Curacion");
    }
}
