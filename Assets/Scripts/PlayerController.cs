using UnityEngine;

public class PlayerController : MonoBehaviour {
	
	[SerializeField] private float moveSpeed;
	private new Rigidbody rigidbody;

	private void Start() {
		rigidbody = GetComponent<Rigidbody>();
	}

	private void Update() {
		var moveInput = Input.GetAxis("Horizontal");
		rigidbody.velocity = new Vector3(moveInput * moveSpeed, rigidbody.velocity.y, 0);
	}
}
