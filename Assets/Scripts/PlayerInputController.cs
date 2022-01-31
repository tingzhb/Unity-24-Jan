using UnityEngine;

public class PlayerInputController : MonoBehaviour {
	
	public float MoveInput { get; private set; }
	public bool JumpInput { get; private set; }
	public bool JumpInputDown { get; private set; }
	public bool JumpInputUp { get; private set; }

	private void Update() => GetInput();
	private void GetInput() {
		MoveInput = Input.GetAxis("Horizontal");
		JumpInputDown = Input.GetButtonDown("Jump");
		JumpInputUp = Input.GetButtonUp("Jump");
		JumpInput = Input.GetButton("Jump");
	}
}
