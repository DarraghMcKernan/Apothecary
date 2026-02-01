using UnityEngine;
using System.Collections;
using System.IO;

public class StreetCheckWin : MonoBehaviour
{
    public float waitSeconds = 5f;
    public SwitchScene gameOverSwitchScene;
    public SwitchScene winSwitchScene;

    private int succcessInt; // 1 = win, 0 = fail

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(checkWin());
    }

    IEnumerator checkWin()
    {
        yield return new WaitForSeconds(waitSeconds);
        succcessInt = PlayerPrefs.GetInt("Success");

        switch(succcessInt)
        {
            case 0:
                gameOverSwitchScene.SwapScene();
                break;
            case 1:
                winSwitchScene.SwapScene();
                break;
        }
    }
}
