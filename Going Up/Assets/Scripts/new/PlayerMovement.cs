using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed;
    public float groundDrag;
    public float jumpForce;
    public float jumpCooldown;
    public float airMultiplier;
    private bool readyToJump;
    public KeyCode jumpKey = KeyCode.Space;
    public float playerHeight;
    public LayerMask whatIsGround;
    private bool grounded;
    public Transform orientation;
    private float horizontalInput;
    private float verticalInput;
    Vector3 moveDirection;
    Rigidbody rb;
    
    private void Start() {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        readyToJump = true;
    }

    private void FixedUpdate() {
        MovePlayer();
    }

    private void Update() {
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);
        MyInput();
        SpeedControl();
        if (grounded == true) {
            rb.linearDamping = groundDrag;
        } else {
            rb.linearDamping = 0;
        }
    }

    private void MyInput() {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        if (Input.GetKey(jumpKey) && readyToJump && grounded == true) {
            readyToJump = false;
            Jump();
            Invoke(nameof(ResetJump), jumpCooldown);
        }
    }

    private void MovePlayer() {
        // Calc movement dir
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
        if (grounded == true) {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
        } else if (!grounded) {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f * airMultiplier, ForceMode.Force);
        }
    }

    private void SpeedControl() {
        Vector3 flatVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
        if (flatVelocity.magnitude > moveSpeed) {
            Vector3 limitedVelocity = flatVelocity.normalized * moveSpeed;
            rb.linearVelocity = new Vector3(limitedVelocity.x, rb.linearVelocity.y, limitedVelocity.z);
        }
    }

    private void Jump() {
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }

    private void ResetJump() {
        readyToJump = true;
    }
}
