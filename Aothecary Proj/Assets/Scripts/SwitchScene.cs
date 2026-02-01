using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SwitchScene : MonoBehaviour
{
    public string scene;
    public bool startSwap = false;
    public float waitSeconds = 1f;

    private void Start()
    {
        if(startSwap)
        {
            SwapScene();
        }
    }
    public void SwapScene()
    {
        StartCoroutine(transition());
    }

    IEnumerator transition()
    {
        yield return new WaitForSeconds(waitSeconds);
        SceneManager.LoadScene(scene);
    }
}
