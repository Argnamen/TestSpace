using UnityEngine;

public class SpaceshipMovement : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float amplitude = 5f;
    [SerializeField] private float frequency = 0.5f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Движение по синусоидальной траектории
        float x = startPosition.x + Mathf.Sin(Time.time * frequency) * amplitude;
        float z = startPosition.z + Time.time * speed;

        transform.position = new Vector3(x, startPosition.y, z);

        // Поворот в направлении движения
        transform.rotation = Quaternion.LookRotation(new Vector3(
            Mathf.Cos(Time.time * frequency) * amplitude,
            0,
            speed));
    }
}