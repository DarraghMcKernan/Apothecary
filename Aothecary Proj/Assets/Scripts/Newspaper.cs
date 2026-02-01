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
            finishedSymptoms += "Sneezing, ";
        }
        else if(gameManager.symptoms[0] == 2)
        {
            finishedSymptoms += "Coughing, ";
        }
        else if (gameManager.symptoms[0] == 3)
        {
            finishedSymptoms += "Runny Nose, ";
        }

        if (gameManager.symptoms[1] == 1)
        {
            finishedSymptoms += "Red Rashes, ";
        }
        else if (gameManager.symptoms[1] == 2)
        {
            finishedSymptoms += "Blue Rash, ";
        }
        else if (gameManager.symptoms[1] == 3)
        {
            finishedSymptoms += "Purple Rash, ";
        }

        if (gameManager.symptoms[2] == 1)
        {
            finishedSymptoms += "and Necrosis in Throat.";
        }
        else if (gameManager.symptoms[2] == 2)
        {
            finishedSymptoms += "and Blisters in Throat.";
        }
        else if (gameManager.symptoms[2] == 3)
        {
            finishedSymptoms += "and Cuts in Throat.";
        }

        newsText.text = finishedSymptoms;
    }
}
