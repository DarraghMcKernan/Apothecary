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

    public GameObject herbSelector;
    public GameObject liquidSelector;
    public GameObject powderSelector;

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
        if(Input.GetKeyDown(KeyCode.C))
        {
            confirmConcotion();
        }
    }

    public void confirmConcotion()
    {
        playerConcoction[0] = herbSelector.GetComponent<SelectorCollider>().guess;
        Debug.Log(herbSelector.GetComponent<SelectorCollider>().guess);

        playerConcoction[1] = liquidSelector.GetComponent<SelectorCollider>().guess;

        playerConcoction[2] = powderSelector.GetComponent<SelectorCollider>().guess;
        winCheck();
    }

    void winCheck()
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
