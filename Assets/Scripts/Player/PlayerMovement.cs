using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [HideInInspector] public bool canDoubleJump = true;
    [HideInInspector] public bool isGrounded;

    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;

    private Rigidbody _rb;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var movement = Input.GetAxis("Horizontal");

        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded && _rb.velocity.y<=0)
        {
            Jump();
        }
        else if (canDoubleJump && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
            canDoubleJump = false;
        }
    }

    private void Jump()
    {
        _rb.AddForce(new Vector2(0, jumpForce), ForceMode.Impulse);
    }

}
