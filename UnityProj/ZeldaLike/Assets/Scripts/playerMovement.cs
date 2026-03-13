using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public Vector2 moveDirection;

    public Transform rotPoint;


    public InputActionReference move;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Update()
    {
        moveDirection = move.action.ReadValue<Vector2>();
    }
    private void FixedUpdate()
    {

        rb.linearVelocity = new Vector3(moveDirection.x * speed, rb.linearVelocity.y, moveDirection.y * speed);
    }
}
