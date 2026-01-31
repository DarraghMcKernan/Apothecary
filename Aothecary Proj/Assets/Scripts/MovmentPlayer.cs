using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class MovmentPlayer : MonoBehaviour
{
    [SerializeField] private int speed = 100;
    private Vector2 moveInput;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Camera workCamera;
    private bool isCamera = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCamera.enabled = true;
        workCamera.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.position += new Vector3(0, 0, moveInput.x) * speed;
    }

    public void OnMove(InputAction.CallbackContext ctx)
    {
        moveInput = ctx.ReadValue<Vector2>();
        
    }
    public void OnSpace(InputAction.CallbackContext ctx)
    {
        if (isCamera)
        {
            isCamera = false;
            mainCamera.enabled = false;
            workCamera.enabled = true;
        }
        else
        {
            isCamera = true;
            workCamera.enabled = false;
            mainCamera.enabled = true;
        }
    }
}
