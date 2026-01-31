using UnityEngine;
using UnityEngine.Events;

public class Events : MonoBehaviour
{
    public UnityEvent events;
    public KeyCode interactKey;
    private bool inRange;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inRange = false;    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && inRange)
        {
            events.Invoke();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            inRange = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            inRange = false;
        }
    }
}
