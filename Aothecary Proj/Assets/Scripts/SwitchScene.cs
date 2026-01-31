using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public string scene;
    public void SwapScene()
    {
        SceneManager.LoadScene(scene);
    }
}
