using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour {
    
    [SerializeField] private float jumpForce;
    private GroundChecker groundChecker;
    private PlayerInputController playerInputController;
    private new Rigidbody rigidbody;

    private void Start() {
        rigidbody = GetComponent<Rigidbody>();
        playerInputController = GetComponent<PlayerInputController>();
        groundChecker = GetComponent<GroundChecker>();
    }
    void Update() => HandleImmediateJump();
    private void HandleImmediateJump() {
        if (playerInputController.JumpInputDown && groundChecker.IsGrounded) {
            rigidbody.AddForce(Vector3.up * jumpForce);
        }
    }
}
