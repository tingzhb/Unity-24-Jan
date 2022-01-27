using UnityEngine;

public class PlayerController : MonoBehaviour {
	
	[SerializeField] private float moveSpeed;
	private PlayerInputController playerInputController;
	private new Rigidbody rigidbody;

	private void Start() {
		rigidbody = GetComponent<Rigidbody>();
		playerInputController = GetComponent<PlayerInputController>();
	}

	private void Update() {
		rigidbody.velocity = new Vector3(playerInputController.MoveInput * moveSpeed, rigidbody.velocity.y, 0);
	}
}
