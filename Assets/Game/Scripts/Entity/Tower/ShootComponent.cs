using UnityEngine;

public class ShootComponent : MonoBehaviour
{
    [SerializeField] private float fireRate;
    [SerializeField] private GameObject bulletPrefab;

    private bool isShoot;

    public void Shoot()
    {
        if (isShoot) return;

        isShoot = true;
        Invoke(nameof(DelayShoot), fireRate);
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }

    private void DelayShoot()
    {       
        isShoot = false;
    }
}
