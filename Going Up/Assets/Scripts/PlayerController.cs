using Unity.Collections;
using UnityEngine;

[DefaultExecutionOrder(-1)]
public class PlayerController : MonoBehaviour {

    [SerializeField] private CharacterController characterController;
    [SerializeField] private Camera mainCamera;
    private PlayerLocomotionInput playerLocomotionInput;
    private Vector2 cameraRotation = Vector2.zero;
    private Vector2 playerTargetRotation = Vector2.zero;
    [Header ("Components")]
    public float runAcceleration = 0.25f;
    public float runSpeed = 4f;
    public float drag = 0.1f;
    [Header ("Camera settings")]
    public float lookSensH = 0.1f;
    public float lookSensV = 0.1f;
    public float lookLimitV = 89f;

    private void Awake() {
        playerLocomotionInput = GetComponent<PlayerLocomotionInput>();
    }

    private void Update() {
        Vector3 cameraForwardXZ = new Vector3 (mainCamera.transform.forward.x, 0f, mainCamera.transform.forward.z).normalized;
        Vector3 cameraRightXZ = new Vector3 (mainCamera.transform.right.x, 0f, mainCamera.transform.right.z).normalized;
        Vector3 movementDirection = cameraRightXZ * playerLocomotionInput.MovementInput.x + cameraForwardXZ * playerLocomotionInput.MovementInput.y;
        Vector3 movementDelta = movementDirection * runAcceleration * Time.deltaTime;
        Vector3 newVelocity = characterController.velocity + movementDelta;
        // Add drag to player
        Vector3 currentDrag = newVelocity.normalized * drag * Time.deltaTime;
        newVelocity = (newVelocity.magnitude > drag * Time.deltaTime) ? newVelocity - currentDrag : Vector3.zero;
        newVelocity = Vector3.ClampMagnitude(newVelocity, runSpeed);
        // Move character 
        characterController.Move(newVelocity * Time.deltaTime);
    }

    private void LateUpdate() {
        cameraRotation.x += lookSensH * playerLocomotionInput.LookInput.x;
        cameraRotation.y = Mathf.Clamp(cameraRotation.y - lookSensV * playerLocomotionInput.LookInput.y, - lookLimitV, lookLimitV);
        playerTargetRotation.x += transform.eulerAngles.x + lookSensH * playerLocomotionInput.LookInput.x;
        transform.rotation = Quaternion.Euler(0f, playerTargetRotation.x, 0f);
        mainCamera.transform.rotation = Quaternion.Euler(cameraRotation.y, cameraRotation.x, 0f);
    }
}
