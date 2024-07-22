using UnityEngine;

public class Grower : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;

    void Update()
    {
        transform.localScale += Vector3.one * _speed * Time.deltaTime;
    }
}