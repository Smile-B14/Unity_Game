using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class JumpWithRaycast : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float jumpForce;
    [SerializeField] private float groundDetectionDistance;
    [SerializeField] private LayerMask groundMask;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
    }
    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, groundDetectionDistance, 1 << 3 | 1 << 4);
    }
}
