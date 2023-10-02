using UnityEngine;

public class ShootComponent : MonoBehaviour
{
    [SerializeField] private float fireRate;
    [SerializeField] private GameObject bulletPrefab;

    [SerializeField] private int lvl;
    [SerializeField] private int maxLvl;

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

    public bool IsMaxLvl()
    {
        if (lvl == maxLvl) return true;
     
        return false;
    }

    public void DeacreaseFireRate(float countAdded)
    {
        lvl++;
        fireRate -= (countAdded / 10);
    }
}
