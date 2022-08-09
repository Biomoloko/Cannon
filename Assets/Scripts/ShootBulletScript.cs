using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBulletScript : MonoBehaviour
{
    public int shootSpeed = 1;
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * shootSpeed, ForceMode.Impulse);
    }

    void Update()
    {
        
    }
}
