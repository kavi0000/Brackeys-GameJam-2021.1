﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;

    public GameObject bulletPrefab;

    public AudioSource gunFire;

    void Update ()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot ()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        gunFire.Play();
    }
}
