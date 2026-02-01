using UnityEngine;

public class ClearData : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("Day", 1);
    }

}
