using UnityEngine;

public class ShipHit : MonoBehaviour
{
    [SerializeField] private GameObject explosionEffect;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("Projectile"))
        {
            // ������� ������ ������
            Instantiate(explosionEffect, transform.position, Quaternion.identity);

            // ���������� �������
            Destroy(gameObject);

            // ���������� ������
            Destroy(collision.gameObject);
        }
    }
}