using UnityEngine;

public class ShipHit : MonoBehaviour
{
    [SerializeField] private GameObject explosionEffect;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("Projectile"))
        {
            // —оздать эффект взрыва
            Instantiate(explosionEffect, transform.position, Quaternion.identity);

            // ”ничтожить корабль
            Destroy(gameObject);

            // ”ничтожить снар€д
            Destroy(collision.gameObject);
        }
    }
}