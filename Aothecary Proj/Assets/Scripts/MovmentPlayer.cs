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
    [SerializeField] private Camera liquidCamera;
    [SerializeField] private Camera powderCamera;
    private bool isCamera = true;

    private bool onWorkTable = false;
    private bool onLiquidTable = false;
    private bool onPowderTable = false;
    [SerializeField] private Transform herbTable;
    [SerializeField] private Transform liquidTable;
    [SerializeField] private Transform powderTable;

    [SerializeField] private float workTableSize = 2;

    [SerializeField] private Transform playerTextureTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCamera.enabled = true;
        workCamera.enabled = false;
        liquidCamera.enabled = false;
        powderCamera.enabled = false;
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
        if (transform.position.z <= herbTable.position.z + workTableSize && transform.position.z >= herbTable.position.z - workTableSize)
        {
            onWorkTable = true;
        }
        else
        {
            onWorkTable = false;
        }

        if (transform.position.z <= liquidTable.position.z + workTableSize && transform.position.z >= liquidTable.position.z - workTableSize)
        {
            onLiquidTable = true;
        }
        else
        {
            onLiquidTable = false;
        }

        if (transform.position.z <= powderTable.position.z + workTableSize && transform.position.z >= powderTable.position.z - workTableSize)
        {
            onPowderTable = true;
        }
        else
        {
            onPowderTable = false;
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
            return;
            
        }
        else if(!isCamera && onWorkTable)
        {
            //change on camera home
            isCamera = true;
            workCamera.enabled = false;
            mainCamera.enabled = true;
        }

        if (isCamera && onLiquidTable)
        {
            // change on camera work
            isCamera = false;
            liquidCamera.enabled = true;
            mainCamera.enabled = false;
            return;

        }
        else if(!isCamera && onLiquidTable) 
        {
            //change on camera home
            isCamera = true;
            liquidCamera.enabled = false;
            mainCamera.enabled = true;
        }

        if (isCamera && onPowderTable)
        {
            // change on camera work
            isCamera = false;
            powderCamera.enabled = true;
            mainCamera.enabled = false;
            return;

        }
        else if (!isCamera && onPowderTable)
        {
            //change on camera home
            isCamera = true;
            powderCamera.enabled = false;
            mainCamera.enabled = true;
        }
    } 
}
