using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SwitchScene : MonoBehaviour
{
    public string scene;
    public void SwapScene()
    {
        StartCoroutine(transition());
    }

    IEnumerator transition()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(scene);
    }
}
