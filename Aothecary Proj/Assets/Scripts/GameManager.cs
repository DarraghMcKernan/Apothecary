using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    const int symptomCount = 3;
    private List<int> symptoms = new List<int>();//the games randomly chosen sickness symptoms
    private List<int> herb = new List<int>();
    private List<int> liquid = new List<int>();
    private List<int> powder = new List<int>();
    private List<int> playerConcoction = new List<int>();//the players guesses
    bool cureSuccessful = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0; i < symptomCount; i++)
        {
            playerConcoction.Add(0);
            symptoms.Add(Random.Range(0, symptomCount) + 1);
            Debug.Log("Symptom " + i + " = " + symptoms[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playerHerbGuess(int t_herbGuess)
    {
        playerConcoction[0] = t_herbGuess;
    }
    public void playerLiquidGuess(int t_liquidGuess)
    {
        playerConcoction[1] = t_liquidGuess;
    }
    public void playerPowderGuess(int t_powderGuess)
    {
        playerConcoction[2] = t_powderGuess;
    }

    public void confirmConcotion()
    {
        WinCheck();
    }

    void WinCheck()
    {
        //if player inputs all match symptoms make cure successful true
        if (playerConcoction[0] == symptoms[0] &&
            playerConcoction[1] == symptoms[1] &&
            playerConcoction[2] == symptoms[2])
        {
            cureSuccessful = true;
        }
        Debug.Log(cureSuccessful);
    }
}
