using UnityEngine;
using TMPro;

public class Newspaper : MonoBehaviour
{
    public TextMeshProUGUI newsText;
    public GameManager gameManager;
    private string finishedSymptoms = "";
    public void Start()
    {
        if (gameManager.symptoms[0] == 1)
        {
            finishedSymptoms += "Sternutatio, ";
        }
        else if(gameManager.symptoms[0] == 2)
        {
            finishedSymptoms += "Tussis, ";
        }
        else if (gameManager.symptoms[0] == 3)
        {
            finishedSymptoms += "Nasus Fluens, ";
        }

        if (gameManager.symptoms[1] == 1)
        {
            finishedSymptoms += "Eruptiones rubrae, ";
        }
        else if (gameManager.symptoms[1] == 2)
        {
            finishedSymptoms += "Eruptio caerulea, ";
        }
        else if (gameManager.symptoms[1] == 3)
        {
            finishedSymptoms += "Eruptio purpurea, ";
        }

        if (gameManager.symptoms[2] == 1)
        {
            finishedSymptoms += "and Necrosis in Gutture.";
        }
        else if (gameManager.symptoms[2] == 2)
        {
            finishedSymptoms += "and Vesicae in Gutture.";
        }
        else if (gameManager.symptoms[2] == 3)
        {
            finishedSymptoms += "and Sectiones in Gutture.";
        }

        newsText.text = finishedSymptoms;
    }
}
