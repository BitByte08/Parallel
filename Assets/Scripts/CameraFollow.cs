using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;    // 따라갈 플레이어 Transform
    public float smoothSpeed = 0.125f;  // 부드럽게 따라가는 속도
    public Vector3 offset;      // 플레이어와 카메라 사이 거리

    void LateUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
