using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//СКРИПТ для зброї. Вистріл при нажиманні на ЛКМ

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }


    void Shoot()
    {
        // shooting logic
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

    }
}
