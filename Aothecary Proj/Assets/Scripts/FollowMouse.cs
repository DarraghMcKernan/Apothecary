using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class FollowMouse : MonoBehaviour
{
    public string cameraName = string.Empty;
    private Camera workbenchCamera;
    private bool isHoldMouse = false;
    private Vector3 worldPos;
    public bool workbenchActive = false;
    [SerializeField] private float sizeObject = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        workbenchCamera = GameObject.FindWithTag(cameraName).GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        //rb.AddForce(0,0f,0);
        mousePos.z = workbenchCamera.nearClipPlane + 6f; // Distance from camera
        worldPos = workbenchCamera.ScreenToWorldPoint(mousePos);
        //if this workbench is active
        if (workbenchActive == true && Input.GetMouseButton(0) && worldPos.x <= transform.position.x + sizeObject && worldPos.x >= transform.position.x - sizeObject && worldPos.z <= transform.position.z + sizeObject && worldPos.z >= transform.position.z - sizeObject || isHoldMouse)
        {
            transform.position = new Vector3(worldPos.x, worldPos.y, worldPos.z);
            isHoldMouse = true;
            if (!Input.GetMouseButton(0))
            {
                isHoldMouse = false;
            }
        }

    }
    public void ClickOnObject(InputAction.CallbackContext ctx)
    {

    }
}
