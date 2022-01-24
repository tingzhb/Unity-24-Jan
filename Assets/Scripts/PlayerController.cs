using UnityEngine;

public class PlayerController : MonoBehaviour {
	[SerializeField] private float moveSpeed;
	[SerializeField] private float jumpForce;
	[SerializeField] private new Rigidbody rigidbody;

	private void Start() {
		rigidbody = GetComponent<Rigidbody>();
	}

	private void Update() {
		var moveInput = Input.GetAxis("Horizontal");
		rigidbody.velocity = new Vector3(moveInput * moveSpeed, rigidbody.velocity.y, 0);

		var jumpInput = Input.GetKeyDown(KeyCode.Space);
		if (jumpInput && rigidbody.velocity.y == 0) {
			rigidbody.AddForce(Vector3.up * jumpForce);
		}
	}
}
