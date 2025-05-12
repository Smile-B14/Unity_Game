using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    public float rotateSpeed = 100;
    public float jumpForce = 500;
    private Rigidbody rb;
    private bool canJump = false;
 // private Vector3 dir = new();

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

   void Update()
    {
        // Moving

        //dir.x = Input.GetAxisRaw("Vertical");
        //dir.z = -Input.GetAxisRaw("Horizontal");
        //dir.Normalize();
        //transform.Rotate(0, 3, 0);
        //transform.Translate(dir * speed * Time.deltaTime);
        //Debug.Log(dir.x = Input.GetAxisRaw("Vertical"));
        //Debug.Log(dir.z = -Input.GetAxisRaw("Horizontal"));


        // Moving W S, Rotate A D

        //transform.Rotate(0, Input.GetAxisRaw("Horizontal") * rotateSpeed * Time.deltaTime, 0);
        transform.Translate(0, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime * speed);
        transform.Translate(Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.AddForce(0, jumpForce, 0);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = new Vector3(0, 2, 0);
        }



    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = true;
            jumpForce = 65;
        }
        if (collision.gameObject.CompareTag("Ground2"))
        {
            canJump = true;
            jumpForce = 125;
        }
        //Debug.Log(collision.gameObject.name);
    }


    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = false;
        }

        if (collision.gameObject.CompareTag("Ground2"))
        {
            canJump = false;
        }
        //Debug.Log(collision.gameObject.name);
    }
}