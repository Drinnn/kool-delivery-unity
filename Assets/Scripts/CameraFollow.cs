using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject follow;
    [SerializeField] private float offset = -10;

    private void LateUpdate()
    {
        transform.position = follow.transform.position + new Vector3(0, 0, offset);
    }
}
