using UnityEngine;

public class PlasmaShot : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform target;
    [SerializeField] private float projectileSpeed = 20f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (!target)
            return;

        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        Vector3 direction = (target.position - transform.position).normalized;
        projectile.GetComponent<Rigidbody>().velocity = direction * projectileSpeed;

        // ����������� ������� ����� 3 �������, ���� �� �� ����� � ����
        Destroy(projectile, 3f);
    }
}
