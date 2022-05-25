using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject ammo;
    public ParticleSystem shootSmoke;
    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootTheAmmo();
        }   
    }
    public void ShootTheAmmo()
    {
        ParticleSystem playSystem = Instantiate(shootSmoke, transform.position, transform.rotation);
        GameObject currentAmmo = Instantiate(ammo, transform.position, transform.rotation);

        Destroy(playSystem, 0.5f);
        Destroy(currentAmmo, 3f);
    }
}
