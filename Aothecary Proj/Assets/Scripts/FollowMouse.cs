using UnityEngine;

public class FollowMouse : MonoBehaviour
{

    public Camera workbenchCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = workbenchCamera.nearClipPlane + 6f; // Distance from camera
        Vector3 worldPos = workbenchCamera.ScreenToWorldPoint(mousePos);
        transform.position = new Vector3(worldPos.x, worldPos.y, worldPos.z);
    }
}
