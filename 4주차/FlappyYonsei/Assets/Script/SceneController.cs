using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene"); 
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }
}
