using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 5f;

    public float jumpPower = 5f;

    public float gravity = -20f;

    private float verticalVelocity;
    private Vector2 moveInput;
    private CharacterController contoller;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        contoller = GetComponent<CharacterController>();
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    public void OnJump(InputValue value)
    {
        if (value.isPressed && contoller.isGrounded)
        {
            verticalVelocity = jumpPower;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (contoller.isGrounded && verticalVelocity < 0f)
        {
            verticalVelocity = -2f;
        }

        verticalVelocity += gravity * Time.deltaTime;

        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y);
        move *= moveSpeed;
        move.y = verticalVelocity;

        contoller.Move(move * Time.deltaTime);
    }
}
