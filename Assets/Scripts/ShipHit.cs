using UnityEngine;

public class ShipHit : MonoBehaviour
{
    [SerializeField] private GameObject explosionEffect;

    public int health = 100;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("Projectile"))
        {
            health -= 40;

            if (health <= 0)
            {
                Instantiate(explosionEffect, transform.position, Quaternion.identity);
                // ”ничтожить корабль
                Destroy(gameObject);
            }

            // ”ничтожить снар€д
            Destroy(collision.gameObject);
        }
    }
}