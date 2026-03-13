using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRotation : MonoBehaviour
{
    public Vector2 lookDirection;

    public InputActionReference look;

    public void Update()
    {
        lookDirection = look.action.ReadValue<Vector2>();
    }
    private void FixedUpdate()
    {
        transform.eulerAngles += new Vector3(lookDirection.y, -lookDirection.x);
    }
}
