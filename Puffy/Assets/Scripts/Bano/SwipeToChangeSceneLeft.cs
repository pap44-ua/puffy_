using UnityEngine;
using UnityEngine.SceneManagement;

public class SwipeToChangeSceneLeft : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("Cocina");
    }
}
