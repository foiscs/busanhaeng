using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class CameraMove : MonoBehaviour
{
    public bool drag;

    public float moveSpeed = 1f;

    public float heightSize;
    public float WidhtSize;

    public int movePixel = 20;

    private Vector3 position;
    public Vector3 dragOrigin;

    private void Start()
    {
        heightSize = Screen.height;
        WidhtSize = Screen.width;

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            drag = true;
        if (Input.GetMouseButtonUp(0))
            drag = false;

        if (drag)
        {
            position = new Vector3(-Input.GetAxis("Mouse X"), -Input.GetAxis("Mouse Y"));
        }
        else
        {
            if (Input.mousePosition.x < movePixel)
                position = Vector3.left * moveSpeed;
            if (Input.mousePosition.x > WidhtSize - movePixel)
                position = Vector3.right * moveSpeed;
            if (Input.mousePosition.y < movePixel)
                position = Vector3.down * moveSpeed;
            if (Input.mousePosition.y > heightSize - movePixel)
                position = Vector3.up * moveSpeed;
        }
        transform.position += position;
        position = Vector3.zero;
    }
}
