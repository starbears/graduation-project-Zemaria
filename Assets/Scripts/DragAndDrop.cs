using System;
using System.Collections;
using System.Collections.Generic;
using BehaviorDesigner.Runtime.Tasks.Unity.UnityInput;
using UnityEngine;
using UnityEngine.InputSystem;

public class DragAndDrop : MonoBehaviour
{
    private Camera mainCamera;
    
  //  public Vector3 _dragoffset;

    public bool isDragging = true;

    [SerializeField]
    private GameObject Paper;

    public SpriteRenderer PaperSpriteRenderer;

    public Rigidbody2D PaperRigidbody2D;
    //
    //
    //
    // // void Start()
    // // {
    // //     
    // // }
    //
    // // Update is called once per frame
    // void Update()
    // {
    //    // Debug.Log(Input.mousePosition);
    //     // {
    //     //     
    //     //     Vector3 mouseWorldPostition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
    //     //     mouseWorldPostition.z = 0f;
    //     //     transform.position = mouseWorldPostition;
    //     //
    //     // }
    //     //
    //     // if (mouseWorldPostition == null)
    //     // {
    //     //     throw new Exception("mouseWorldPostition = null");
    //     // }
    //
    // }
    //
    //
    // private Vector3 _dragOffset;
    // private void OnMouseDown()
    // {
    //     _dragOffset = transform.position - GetMousePos();
    //     PaperRigidbody2D.bodyType = RigidbodyType2D.Kinematic;
    //
    // }
    //
    // private void OnMouseUp()
    // {
    //     if (isDragging = true)
    //     {
    //         
    //         PaperRigidbody2D.bodyType = RigidbodyType2D.Dynamic;
    //         
    //     }
    //     else
    //     {
    //         
    //         PaperRigidbody2D.bodyType = RigidbodyType2D.Static;
    //     }
    //     
    // }
    //
    // // void OnMouseDrag()
    // // {
    // //     transform.position = GetMousePos() + _dragOffset;
    // // }
    //
    // Vector3 GetMousePos()
    // {
    //     var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //     mousePos.z = 0;
    //     return mousePos;
    // }
    // private void OnMouseDrag()
    // {
    //    
    //     isDragging = true;
    //     if (isDragging = true)
    //     {
    //         transform.position = GetMousePos() + _dragOffset;
    //         Vector2 screenMousePosition = Mouse.current.position.ReadValue();
    //         Vector2 MousePosition = Camera.main.ScreenToWorldPoint(screenMousePosition);
    //         Paper.transform.position = MousePosition;
    //     }
    // }
}
