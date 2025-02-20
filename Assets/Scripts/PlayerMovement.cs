using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f; 
    [SerializeField] private PlayerInput playerInput;

    private Vector2 moveInput;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }
    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        playerInput.neverAutoSwitchControlSchemes = true;   
        Debug.Log(moveInput);
    }

    private void FixedUpdate()
    {
        Vector2 movement = moveInput * speed * Time.deltaTime;
        rb.velocity = movement;
    }
}
