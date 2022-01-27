using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour {
    
    [SerializeField] private float jumpForce;
    private PlayerInputController playerInputController;
    private new Rigidbody rigidbody;

    private void Start() {
        rigidbody = GetComponent<Rigidbody>();
        playerInputController = GetComponent<PlayerInputController>();
    }
    void Update()
    {
        if (playerInputController.JumpInput && rigidbody.velocity.y == 0) {
            rigidbody.AddForce(Vector3.up * jumpForce);
        }
    }
}
