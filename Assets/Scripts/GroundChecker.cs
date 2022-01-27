using System;
using UnityEngine;

public class GroundChecker : MonoBehaviour {

	public bool IsGrounded { get; private set; }
	[SerializeField] private float groundCheckLength = 1f;
	[SerializeField] private LayerMask groundLayers;
	private void Update() {
		var ray = new Ray(transform.position, Vector3.down);
		IsGrounded = Physics.Raycast(ray, groundCheckLength);
		Debug.DrawRay(transform.position, Vector3.down * groundCheckLength, Color.magenta);
	}

}
