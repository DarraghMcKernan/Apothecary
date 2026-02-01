using UnityEngine;
using TMPro;

public class DayManager : MonoBehaviour
{
    public TextMeshProUGUI dayText;
    private int dayNum;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dayNum = PlayerPrefs.GetInt("Day"); 
        dayText.text = "D A Y  " + dayNum.ToString();
    }
}
