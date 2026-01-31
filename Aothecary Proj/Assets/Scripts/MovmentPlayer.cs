using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class MovmentPlayer : MonoBehaviour
{
    [SerializeField] private Transform room;
    public float sizeRoom = 20;

    [SerializeField] private int speed = 10;
    private Vector2 moveInput;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Camera workCamera;
    private bool isCamera = true;

    private bool onWorkTable = false;
    [SerializeField] private Transform workTable;
    [SerializeField] private float workTableSize = 20;

    [SerializeField] private Transform playerTextureTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCamera.enabled = true;
        workCamera.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isCamera )
        {
            move();
            
        }

       
        
    }

    private void move()
    {
        if (transform.position.z >= room.transform.position.z - sizeRoom && moveInput.x < 0)
        {
            gameObject.transform.position -= new Vector3(0, 0, 1) * speed * Time.deltaTime; // movement player to left
        }
        if (transform.position.z <= room.transform.position.z + sizeRoom && moveInput.x > 0)
        {
            gameObject.transform.position += new Vector3(0, 0, 1) * speed * Time.deltaTime; // movement player to right
        }
        //Check table
        if (transform.position.z <= workTable.position.z + workTableSize && transform.position.z >= workTable.position.z - workTableSize)
        {
            onWorkTable = true;
        }
        else
        {
            onWorkTable = false;
        }
    }

    public void OnMove(InputAction.CallbackContext ctx)
    {
        moveInput = ctx.ReadValue<Vector2>();
        if(moveInput.x < 0)
        {
            playerTextureTransform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            playerTextureTransform.localScale = new Vector3(1, 1, 1);
        }
        
    }
    public void OnSpace(InputAction.CallbackContext ctx)
    {
        if (isCamera && onWorkTable)
        {
            // change on camera work
            isCamera = false;
            workCamera.enabled = true;
            mainCamera.enabled = false;
            
        }
        else
        {
            //change on camera home
            isCamera = true;
            workCamera.enabled = false;
            mainCamera.enabled = true;
        } 
    } 
}
