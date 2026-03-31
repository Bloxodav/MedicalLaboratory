using UnityEngine;

public class lookAt : MonoBehaviour
{
    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void LateUpdate()
    {
        Vector3 direction = mainCamera.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Euler(0f, rotation.eulerAngles.y, 0f);
    }
}