using UnityEngine;

public class PlasmaShot : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform target;
    [SerializeField] private float projectileSpeed = 20f;

    private int number = 3;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            number--;

            if (number <= 0 && target)
            {
                number = 3;
                Shoot();
            }
            else
            {
                RandomShoot();
            }
        }
    }

    void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        Vector3 direction = (target.position - transform.position).normalized;
        projectile.GetComponent<Rigidbody>().velocity = direction * projectileSpeed;

        // Уничтожение снаряда через 3 секунды, если он не попал в цель
        Destroy(projectile, 3f);
    }

    void RandomShoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        Vector3 direction = (Vector3.one * UnityEngine.Random.Range(-5, 5) + transform.position).normalized;
        projectile.GetComponent<Rigidbody>().velocity = direction * projectileSpeed;

        // Уничтожение снаряда через 3 секунды, если он не попал в цель
        Destroy(projectile, 3f);
    }
}
