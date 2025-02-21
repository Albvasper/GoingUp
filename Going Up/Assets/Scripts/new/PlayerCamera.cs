using UnityEngine;

public class PlayerCamera : MonoBehaviour {

    public float camSensX;
    public float camSensY;
    public Transform orientation;
    public float xRotation;
    public float yRotation;

    private void Start() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update() {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * camSensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * camSensY;
        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
