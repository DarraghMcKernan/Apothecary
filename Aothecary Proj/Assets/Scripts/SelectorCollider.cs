using UnityEngine;

public class SelectorCollider : MonoBehaviour
{
    public int guess;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Guess1")
        {
            guess = 1;
        }
        if (collision.gameObject.tag == "Guess2")
        {
            guess = 2;
        }
        if (collision.gameObject.tag == "Guess3")
        {
            guess = 3;
        }
        Debug.Log(guess);
    }
}
