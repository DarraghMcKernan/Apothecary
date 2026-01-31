using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class FollowMouse : MonoBehaviour
{

    [SerializeField] private Camera workbenchCamera;
    private Vector2 clickMouse;
    private Vector3 worldPos;
    [SerializeField] private float sizeObject = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        workbenchCamera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        
        mousePos.z = workbenchCamera.nearClipPlane + 6f; // Distance from camera
        worldPos = workbenchCamera.ScreenToWorldPoint(mousePos);
        if (Input.GetMouseButton(0) && worldPos.x <= transform.position.x + sizeObject && worldPos.x >= transform.position.x - sizeObject && worldPos.z <= transform.position.z + sizeObject && worldPos.z >= transform.position.z - sizeObject)
        {
            transform.position = new Vector3(worldPos.x, worldPos.y, worldPos.z);

        }

    }
    public void ClickOnObject(InputAction.CallbackContext ctx)
    {

    }
}
