using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour {
    
    [SerializeField] private float jumpForce;
    private new Rigidbody rigidbody;

    private void Start() {
        rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        var jumpInput = Input.GetKeyDown(KeyCode.Space);
        if (jumpInput && rigidbody.velocity.y == 0) {
            rigidbody.AddForce(Vector3.up * jumpForce);
        }
    }
}
