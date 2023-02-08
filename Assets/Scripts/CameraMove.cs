using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform _target;
    void LateUpdate()
    {
        transform.position = _target.position;
    }
}
