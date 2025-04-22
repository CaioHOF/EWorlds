using UnityEngine;

public class GlobeController : MonoBehaviour
{
    public float rotationSpeed = 50f;
    public float zoomSpeed = 10f;
    private Vector3 lastMousePosition;

    void Update()
    {
        // Rotação com o mouse
        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - lastMousePosition;
            transform.Rotate(Vector3.up, -delta.x * rotationSpeed * Time.deltaTime, Space.World);
            transform.Rotate(Vector3.right, delta.y * rotationSpeed * Time.deltaTime, Space.Self);
        }

        // Zoom com scroll
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        Camera.main.transform.Translate(Vector3.forward * scroll * zoomSpeed, Space.Self);

        lastMousePosition = Input.mousePosition;
    }
}