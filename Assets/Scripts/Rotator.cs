using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;

    void Update()
    {
        transform.Rotate(Vector3.up, _speed);
    }
}