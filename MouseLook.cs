using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Transform playerbody;
    public float MouseSens = 100f;
    float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }



    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * MouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * MouseSens * Time.deltaTime;

        playerbody.Rotate(Vector3.up * mouseX);

        xRotation -= mouseY;

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
    }
}
