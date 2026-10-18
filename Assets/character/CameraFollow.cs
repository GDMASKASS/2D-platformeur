using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private bool followX = true;
    [SerializeField] private bool followY = false;
    [SerializeField] private float smoothSpeed = 5f;

    private void LateUpdate()
    {
        if (target == null) return;

        Vector3 pos = transform.position;

        if (followX) pos.x = Mathf.Lerp(pos.x, target.position.x, smoothSpeed * Time.deltaTime);
        if (followY) pos.y = Mathf.Lerp(pos.y, target.position.y, smoothSpeed * Time.deltaTime);

        transform.position = pos;
    }
}