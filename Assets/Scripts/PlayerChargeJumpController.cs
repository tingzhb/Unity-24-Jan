using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChargeJumpController : MonoBehaviour
{
    [SerializeField] private float minimumJumpForce;
    [SerializeField] private float maximumJumpForce;
    [SerializeField] private float chargeTime;

    private float jumpCharge;
    private GroundChecker groundChecker;
    private PlayerInputController playerInputController;
    private new Rigidbody rigidbody;

    private void Start() {
        rigidbody = GetComponent<Rigidbody>();
        playerInputController = GetComponent<PlayerInputController>();
        groundChecker = GetComponent<GroundChecker>();
    }
    void Update() {
        HandleChargeJump();
    }
    private void HandleChargeJump() {
        if (playerInputController.JumpInput && groundChecker.IsGrounded) {
            jumpCharge += Time.deltaTime / chargeTime;
        }
        if (playerInputController.JumpInputUp && groundChecker.IsGrounded) {
            var jumpForce = Mathf.Lerp(minimumJumpForce, maximumJumpForce, jumpCharge);
            rigidbody.AddForce(Vector3.up * jumpForce);
            jumpCharge = 0f;
        }
    }
}
