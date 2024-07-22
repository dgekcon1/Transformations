using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed = 0.05f;

    void Update()
    {
        transform.Translate(_speed * Time.deltaTime * transform.forward);
    }
}