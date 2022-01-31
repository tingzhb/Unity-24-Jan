using UnityEngine;

public class PlayerWalkController : MonoBehaviour {
	
	[SerializeField] private float moveSpeed;
	private PlayerInputController playerInputController;
	private new Rigidbody rigidbody;

	private void Start() {
		rigidbody = GetComponent<Rigidbody>();
		playerInputController = GetComponent<PlayerInputController>();
	}

	private void Update() => HandleWalking();
	private void HandleWalking() {
		rigidbody.velocity = new Vector3(playerInputController.MoveInput * moveSpeed, rigidbody.velocity.y, 0);
	}
}
