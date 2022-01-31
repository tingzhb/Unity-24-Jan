using UnityEngine;

public class PlayerWalkController : MonoBehaviour {
	
	[SerializeField] private float moveSpeed;
	private CommandContainer commandContainer;
	private new Rigidbody rigidbody;

	private void Start() {
		rigidbody = GetComponent<Rigidbody>();
		commandContainer = GetComponentInChildren<CommandContainer>();
	}

	private void Update() => HandleWalking();
	private void HandleWalking() {
		rigidbody.velocity = new Vector3(commandContainer.walkCommand * moveSpeed, rigidbody.velocity.y, 0);
	}
}
